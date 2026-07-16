using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using SmartMed.Managers;
using SmartMed.Helpers;

namespace SmartMed.Models
{
    internal class Order
    {
        // =====================================================
        // Private Fields
        // =====================================================
        private int orderID;
        private int customerID;
        private DateTime orderDate;
        private decimal totalAmount;
        private string orderStatus;
        private List<OrderItem> items;

        private static DatabaseManager db = new DatabaseManager();

        // =====================================================
        // Public Properties
        // =====================================================
        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public decimal TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }

        public string OrderStatus
        {
            get { return orderStatus; }
            set { orderStatus = value; }
        }

        public List<OrderItem> Items
        {
            get { return items; }
            set { items = value; }
        }

        // =====================================================
        // Constructors
        // =====================================================
        public Order()
        {
            orderID = 0;
            customerID = 0;
            orderDate = DateTime.Now;
            totalAmount = 0.0m;
            orderStatus = "Pending";
            items = new List<OrderItem>();
        }

        public Order(int customerID, List<OrderItem> orderItems)
        {
            orderID = 0;
            this.customerID = customerID;
            orderDate = DateTime.Now;
            totalAmount = 0.0m;
            orderStatus = "Pending";
            this.items = orderItems ?? new List<OrderItem>();
        }

        // =====================================================
        // Business Methods (UML)
        // =====================================================

        // Calculate order total by summing each item's subtotal
        public decimal CalculateTotal()
        {
            decimal total = 0.0m;

            if (items == null || items.Count == 0)
                return 0.0m;

            foreach (OrderItem item in items)
            {
                if (item != null && item.Quantity > 0 && item.UnitPrice > 0)
                {
                    total += item.CalculateSubtotal();
                }
            }

            totalAmount = total;
            return totalAmount;
        }

        // Update the order status (both object and database)
        public bool UpdateStatus(string newStatus)
        {
            // Delegate status validation to ValidationHelper
            string statusError = ValidationHelper.ValidateOrderStatus(newStatus);
            if (statusError != null)
            {
                MessageBox.Show(statusError, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Update object
            orderStatus = newStatus;

            // Update database if OrderID exists
            if (orderID <= 0)
            {
                MessageBox.Show("Order has not been saved yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                string sql = "UPDATE [Order] SET OrderStatus = @status WHERE OrderID = @orderID";
                using (SQLiteConnection conn = db.OpenConnection())
                {
                    if (conn == null) return false;
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@orderID", orderID);
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update order status: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Generate order record: insert order and items, reduce stock, return OrderID
        public int GenerateOrderRecord()
        {
            // Validate customer exists
            if (Customer.GetCustomerByID(customerID) == null)
            {
                MessageBox.Show("Customer does not exist.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }

            // Delegate all item and order structure validation to ValidationHelper
            string orderError = ValidationHelper.ValidateOrder(this);
            if (orderError != null)
            {
                MessageBox.Show(orderError, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }

            // Pre-transaction stock check
            foreach (OrderItem item in items)
            {
                if (!Medicine.HasSufficientStock(item.MedicineID, item.Quantity))
                {
                    MessageBox.Show(
                        $"Insufficient stock for medicine ID {item.MedicineID}.",
                        "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return -1;
                }
            }

            // Calculate total before inserting
            CalculateTotal();

            // Start database transaction
            SQLiteConnection conn = null;
            SQLiteTransaction transaction = null;
            try
            {
                conn = db.OpenConnection();
                if (conn == null) return -1;
                transaction = conn.BeginTransaction();

                // 1. Insert order record
                string insertOrderSql = @"INSERT INTO [Order] (CustomerID, OrderDate, TotalAmount, OrderStatus)
                                          VALUES (@customerID, @orderDate, @totalAmount, @orderStatus);
                                          SELECT last_insert_rowid();";

                object newIdObj;
                using (SQLiteCommand cmd = new SQLiteCommand(insertOrderSql, conn, transaction))
                {
                    cmd.Parameters.AddWithValue("@customerID", customerID);
                    cmd.Parameters.AddWithValue("@orderDate", orderDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                    cmd.Parameters.AddWithValue("@orderStatus", orderStatus);
                    newIdObj = cmd.ExecuteScalar();
                }

                if (newIdObj == null || newIdObj == DBNull.Value)
                {
                    transaction.Rollback();
                    MessageBox.Show("Failed to create order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
                int newOrderID = Convert.ToInt32(newIdObj);
                orderID = newOrderID;

                // 2. Insert order items and reduce stock
                foreach (OrderItem item in items)
                {
                    // Insert order item
                    string insertItemSql = @"INSERT INTO OrderItem (OrderID, MedicineID, Quantity, UnitPrice)
                                             VALUES (@orderID, @medicineID, @quantity, @unitPrice)";
                    using (SQLiteCommand cmd = new SQLiteCommand(insertItemSql, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@orderID", newOrderID);
                        cmd.Parameters.AddWithValue("@medicineID", item.MedicineID);
                        cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                        cmd.Parameters.AddWithValue("@unitPrice", item.UnitPrice);
                        cmd.ExecuteNonQuery();
                    }

                    // Reduce medicine stock
                    bool stockReduced = ReduceStock(conn, transaction, item.MedicineID, item.Quantity);
                    if (!stockReduced)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Insufficient stock for medicine ID: " + item.MedicineID,
                                        "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1;
                    }
                }

                // Commit transaction
                transaction.Commit();
                return orderID;
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    try { transaction.Rollback(); } catch { }
                }
                MessageBox.Show("Order placement failed: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            finally
            {
                if (conn != null)
                {
                    db.CloseConnection(conn);
                }
            }
        }

        // =====================================================
        // Static Methods – Order Management (FR-25, FR-26)
        // =====================================================

        /// <summary>
        /// Returns all orders with customer name, item list and prescription flag.
        /// The Items column now shows “MedicineName (xQty), ...” instead of a count.
        /// </summary>
        public static DataTable GetAllOrders()
        {
            DatabaseManager db = new DatabaseManager();
            string sql = @"
                SELECT o.OrderID, o.CustomerID, c.FullName AS CustomerName, 
                       o.OrderDate, o.TotalAmount, o.OrderStatus,
                       (SELECT GROUP_CONCAT(m.MedicineName || ' (x' || oi.Quantity || ')', ', ')
                        FROM OrderItem oi
                        JOIN Medicine m ON oi.MedicineID = m.MedicineID
                        WHERE oi.OrderID = o.OrderID) AS Items,
                       CASE WHEN EXISTS (SELECT 1 FROM Prescription p WHERE p.OrderID = o.OrderID) THEN 'Yes' ELSE 'No' END AS HasPrescription
                FROM [Order] o
                LEFT JOIN Customer c ON o.CustomerID = c.CustomerID
                ORDER BY o.OrderDate DESC;";
            return db.ExecuteQuery(sql);
        }

        /// <summary>
        /// Searches orders with optional filters using parameterised SQL.
        /// The Items column returns medicine names and quantities.
        /// </summary>
        public static DataTable SearchOrders(string customerSearch, string orderIdSearch, string statusFilter)
        {
            DatabaseManager dbMgr = new DatabaseManager();
            DataTable dt = new DataTable();
            try
            {
                using (var conn = dbMgr.OpenConnection())
                {
                    if (conn == null) return dt;

                    string sql = @"
                        SELECT o.OrderID, o.CustomerID, c.FullName AS CustomerName, 
                               o.OrderDate, o.TotalAmount, o.OrderStatus,
                               (SELECT GROUP_CONCAT(m.MedicineName || ' (x' || oi.Quantity || ')', ', ')
                                FROM OrderItem oi
                                JOIN Medicine m ON oi.MedicineID = m.MedicineID
                                WHERE oi.OrderID = o.OrderID) AS Items,
                               CASE WHEN EXISTS (SELECT 1 FROM Prescription p WHERE p.OrderID = o.OrderID) THEN 'Yes' ELSE 'No' END AS HasPrescription
                        FROM [Order] o
                        LEFT JOIN Customer c ON o.CustomerID = c.CustomerID
                        WHERE 1=1 ";

                    List<SQLiteParameter> parameters = new List<SQLiteParameter>();

                    if (!string.IsNullOrWhiteSpace(customerSearch))
                    {
                        if (int.TryParse(customerSearch, out int custId))
                        {
                            sql += " AND (o.CustomerID = @custId OR c.FullName LIKE @custName) ";
                            parameters.Add(new SQLiteParameter("@custId", custId));
                            parameters.Add(new SQLiteParameter("@custName", "%" + customerSearch + "%"));
                        }
                        else
                        {
                            sql += " AND c.FullName LIKE @custName ";
                            parameters.Add(new SQLiteParameter("@custName", "%" + customerSearch + "%"));
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(orderIdSearch) && int.TryParse(orderIdSearch, out int ordId))
                    {
                        sql += " AND o.OrderID = @ordId ";
                        parameters.Add(new SQLiteParameter("@ordId", ordId));
                    }

                    if (!string.IsNullOrWhiteSpace(statusFilter) && statusFilter != "All")
                    {
                        sql += " AND o.OrderStatus = @status ";
                        parameters.Add(new SQLiteParameter("@status", statusFilter));
                    }

                    sql += " ORDER BY o.OrderDate DESC;";

                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                        using (var adapter = new SQLiteDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching orders: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        /// <summary>
        /// Returns summary counts for the dashboard cards.
        /// </summary>
        public static Dictionary<string, int> GetOrderSummary()
        {
            DatabaseManager db = new DatabaseManager();
            Dictionary<string, int> summary = new Dictionary<string, int>
            {
                ["Total"] = Convert.ToInt32(db.ExecuteScalar("SELECT COUNT(*) FROM [Order];") ?? 0),
                ["Pending"] = Convert.ToInt32(db.ExecuteScalar("SELECT COUNT(*) FROM [Order] WHERE OrderStatus='Pending';") ?? 0),
                ["ReadyForPickup"] = Convert.ToInt32(db.ExecuteScalar("SELECT COUNT(*) FROM [Order] WHERE OrderStatus='Ready for Pickup';") ?? 0),
                ["Delivered"] = Convert.ToInt32(db.ExecuteScalar("SELECT COUNT(*) FROM [Order] WHERE OrderStatus='Delivered';") ?? 0)
            };
            return summary;
        }

        /// <summary>
        /// Static helper to update status using the existing instance method.
        /// </summary>
        public static bool UpdateOrderStatus(int orderId, string newStatus)
        {
            Order order = new Order();
            order.OrderID = orderId;
            return order.UpdateStatus(newStatus);
        }

        // =====================================================
        // FR-27 : Customer Order Tracking
        // =====================================================

        /// <summary>
        /// Returns all orders belonging to a specific customer.
        /// Columns: OrderID, OrderDate, TotalAmount, OrderStatus, Items, HasPrescription.
        /// </summary>
        public static DataTable GetOrdersByCustomer(int customerID)
        {
            DatabaseManager db = new DatabaseManager();
            string sql = @"
                SELECT o.OrderID, o.OrderDate, o.TotalAmount, o.OrderStatus,
                       (SELECT GROUP_CONCAT(m.MedicineName || ' (x' || oi.Quantity || ')', ', ')
                        FROM OrderItem oi
                        JOIN Medicine m ON oi.MedicineID = m.MedicineID
                        WHERE oi.OrderID = o.OrderID) AS Items,
                       CASE WHEN EXISTS (SELECT 1 FROM Prescription p WHERE p.OrderID = o.OrderID) THEN 'Yes' ELSE 'No' END AS HasPrescription
                FROM [Order] o
                WHERE o.CustomerID = @customerID
                ORDER BY o.OrderDate DESC;";

            DataTable dt = new DataTable();
            try
            {
                using (var conn = db.OpenConnection())
                {
                    if (conn == null) return dt;
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerID", customerID);
                        using (var adapter = new SQLiteDataAdapter(cmd))
                            adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load customer orders: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        /// <summary>
        /// Returns the item list for a given order.
        /// Columns: MedicineName, Quantity, UnitPrice, Subtotal, PrescriptionRequired.
        /// </summary>
        public static DataTable GetOrderItems(int orderID)
        {
            DatabaseManager db = new DatabaseManager();
            string sql = @"
                SELECT m.MedicineName, oi.Quantity, oi.UnitPrice,
                       (oi.Quantity * oi.UnitPrice) AS Subtotal,
                       CASE WHEN m.PrescriptionRequired = 1 THEN 'Yes' ELSE 'No' END AS PrescriptionRequired
                FROM OrderItem oi
                JOIN Medicine m ON oi.MedicineID = m.MedicineID
                WHERE oi.OrderID = @orderID
                ORDER BY m.MedicineName;";

            DataTable dt = new DataTable();
            try
            {
                using (var conn = db.OpenConnection())
                {
                    if (conn == null) return dt;
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderID", orderID);
                        using (var adapter = new SQLiteDataAdapter(cmd))
                            adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load order items: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        // =====================================================
        // Private Helper – stock reduction
        // =====================================================
        private bool ReduceStock(SQLiteConnection conn, SQLiteTransaction transaction, int medicineID, int quantity)
        {
            string sql = @"UPDATE Medicine SET StockQuantity = StockQuantity - @qty
                           WHERE MedicineID = @medID AND StockQuantity >= @qty";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@qty", quantity);
                cmd.Parameters.AddWithValue("@medID", medicineID);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}