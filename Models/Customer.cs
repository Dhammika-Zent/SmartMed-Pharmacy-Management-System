using System;
using System.Collections.Generic;   // Required for List<T> in search methods
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using SmartMed.Managers;      // DatabaseManager, SessionManager
using SmartMed.Helpers;       // ValidationHelper (retained for helpers)
using SmartMed.Forms;         // Needed for CartForm delegation

namespace SmartMed.Models
{
    internal class Customer : User
    {
        // =====================================================
        // Private Fields
        // =====================================================
        private int customerID;
        private string phone;
        private string address;
        private DateTime createdDate;

        private static DatabaseManager db = new DatabaseManager();
        public static string LastRegistrationError { get; private set; }

        // =====================================================
        // Public Properties
        // =====================================================
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        // =====================================================
        // Constructors
        // =====================================================
        public Customer() : base()
        {
            customerID = 0;
            phone = string.Empty;
            address = string.Empty;
            createdDate = DateTime.Now;
        }

        public Customer(int customerID, int userID, string username, string password,
                        string fullName, string email, string phone, string address,
                        DateTime createdDate)
            : base(userID, username, password, fullName, email)
        {
            this.customerID = customerID;
            this.phone = phone;
            this.address = address;
            this.createdDate = createdDate;
        }

        // =====================================================
        // Authentication Methods (override abstract User methods)
        // =====================================================

        /// <summary>
        /// Authenticate customer against the Customer table.
        /// On success, creates a session and returns true.
        /// </summary>
        public override bool Login()
        {
            string safeUsername = this.Username.Replace("'", "''");
            string safePassword = this.Password.Replace("'", "''");

            string sql = $"SELECT CustomerID, Username, FullName FROM Customer " +
                         $"WHERE Username = '{safeUsername}' AND Password = '{safePassword}'";
            DataTable dt = db.ExecuteQuery(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                int userId = Convert.ToInt32(row["CustomerID"]);
                string user = row["Username"].ToString();
                string fullName = row["FullName"].ToString();

                SessionManager session = new SessionManager();
                session.StartSession(userId, user, fullName, "Customer");
                return true;
            }
            return false;
        }

        /// <summary>
        /// Ends the current session (clears SessionManager).
        /// </summary>
        public override void Logout()
        {
            if (SessionManager.CurrentSession != null)
            {
                SessionManager.CurrentSession.EndSession();
            }
        }

        // =====================================================
        // Registration Method (Customer only)
        // =====================================================
        public bool Register()
        {
            string safeUsername = this.Username.Replace("'", "''");
            string safeEmail = this.Email.Replace("'", "''");

            // Duplicate username check
            string checkUserSql = $"SELECT COUNT(*) FROM Customer WHERE Username = '{safeUsername}'";
            object userCountObj = db.ExecuteScalar(checkUserSql);
            int userCount = userCountObj != null ? Convert.ToInt32(userCountObj) : 0;
            if (userCount > 0)
            {
                LastRegistrationError = "Username already exists. Please choose another.";
                return false;
            }

            // Duplicate email check
            string checkEmailSql = $"SELECT COUNT(*) FROM Customer WHERE Email = '{safeEmail}'";
            object emailCountObj = db.ExecuteScalar(checkEmailSql);
            int emailCount = emailCountObj != null ? Convert.ToInt32(emailCountObj) : 0;
            if (emailCount > 0)
            {
                LastRegistrationError = "Email already exists. Please use a different email.";
                return false;
            }

            // Insert new customer
            string insertSql = "INSERT INTO Customer (Username, Password, FullName, Email, Phone, Address) " +
                               "VALUES ('" + safeUsername + "', " +
                               "'" + this.Password.Replace("'", "''") + "', " +
                               "'" + this.FullName.Replace("'", "''") + "', " +
                               "'" + safeEmail + "', " +
                               "'" + this.Phone.Replace("'", "''") + "', " +
                               "'" + this.Address.Replace("'", "''") + "')";
            int rowsAffected = db.ExecuteNonQuery(insertSql);
            if (rowsAffected > 0)
                return true;

            LastRegistrationError = "Registration failed. Please try again.";
            return false;
        }

        // =====================================================
        // Customer-specific Methods (as per class diagram)
        // =====================================================

        /// <summary>
        /// Adds a medicine to the shopping cart.
        /// Delegates to CartForm, which owns the in‑memory cart logic.
        /// </summary>
        public void AddToCart(Medicine medicine, int quantity)
        {
            // Pass through to the existing static method that manages the cart.
            CartForm.AddToCart(medicine, quantity);
        }


        //search medicine
        public DataTable SearchMedicine(string name, string category, decimal? minPrice,
                                        decimal? maxPrice, bool discountedOnly,
                                        bool prescriptionOnly, bool inStockOnly, string sortBy)
        {
            return Medicine.SearchMedicinesForCustomer(name, category, minPrice, maxPrice,
                                                       discountedOnly, prescriptionOnly,
                                                       inStockOnly, sortBy);
        }

        // =====================================================
        // Profile Management (FR-13 & FR-14)
        // =====================================================

        /// <summary>
        /// Retrieves a full Customer object from the database by CustomerID.
        /// </summary>
        public static Customer GetCustomerByID(int customerID)
        {
            string sql = "SELECT CustomerID, Username, Password, FullName, Email, Phone, Address, CreatedDate " +
                         "FROM Customer WHERE CustomerID = " + customerID;
            DataTable dt = db.ExecuteQuery(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Customer cust = new Customer(
                    Convert.ToInt32(row["CustomerID"]),
                    Convert.ToInt32(row["CustomerID"]),
                    row["Username"].ToString(),
                    row["Password"].ToString(),
                    row["FullName"].ToString(),
                    row["Email"].ToString(),
                    row["Phone"].ToString(),
                    row["Address"].ToString(),
                    Convert.ToDateTime(row["CreatedDate"])
                );
                return cust;
            }
            return null;
        }

        /// <summary>
        /// Updates the customer's own profile (FullName, Email, Phone, Address)
        /// and optionally changes the password.
        /// </summary>
        public bool UpdateProfile(string newPassword, out string errorMessage)
        {
            errorMessage = string.Empty;

            // 1. Check email uniqueness
            if (IsEmailDuplicate(this.Email, this.CustomerID))
            {
                errorMessage = "Email is already in use by another account.";
                return false;
            }

            // 2. Update non‑password fields
            bool basicUpdateOk = UpdateCustomerRecord(this);
            if (!basicUpdateOk)
            {
                errorMessage = "Failed to update profile information.";
                return false;
            }

            // 3. If a new password was supplied, update it separately
            if (!string.IsNullOrEmpty(newPassword))
            {
                try
                {
                    string sql = "UPDATE Customer SET Password = @password WHERE CustomerID = @customerID";
                    using (SQLiteConnection conn = db.OpenConnection())
                    {
                        using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@password", newPassword);
                            cmd.Parameters.AddWithValue("@customerID", this.CustomerID);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    errorMessage = "Password update failed: " + ex.Message;
                    return false;
                }
            }

            return true;
        }


        // =====================================================
        // Customer Order Tracking (FR-27)
        // =====================================================

        /// <summary>
        /// Returns the order history for the currently logged‑in customer.
        /// Delegates to Order.GetOrdersByCustomer().
        /// </summary>
        public DataTable TrackOrder()
        {
            // Customer identity from session
            if (SessionManager.CurrentSession == null)
            {
                MessageBox.Show("No active session. Please log in.", "Session Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            int customerID = SessionManager.CurrentSession.UserID;
            return Order.GetOrdersByCustomer(customerID);
        }



        // =====================================================
        // Internal Helper Methods (now accessible to Admin)
        // =====================================================

        /// <summary>
        /// Updates the core customer record (FullName, Email, Phone, Address).
        /// Made internal static so Admin can reuse it.
        /// </summary>
        internal static bool UpdateCustomerRecord(Customer customer)
        {
            try
            {
                string sql = @"UPDATE Customer SET FullName = @fullName, Email = @email,
                               Phone = @phone, Address = @address WHERE CustomerID = @customerID";
                using (SQLiteConnection conn = db.OpenConnection())
                {
                    if (conn == null) return false;
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@fullName", customer.FullName);
                        cmd.Parameters.AddWithValue("@email", customer.Email);
                        cmd.Parameters.AddWithValue("@phone", customer.Phone);
                        cmd.Parameters.AddWithValue("@address", customer.Address);
                        cmd.Parameters.AddWithValue("@customerID", customer.CustomerID);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Checks whether an email address is already in use by another customer.
        /// Made internal static so Admin can reuse it.
        /// </summary>
        internal static bool IsEmailDuplicate(string email, int excludeCustomerID)
        {
            try
            {
                string sql = "SELECT COUNT(*) FROM Customer WHERE Email = @email AND CustomerID != @excludeID";
                using (SQLiteConnection conn = db.OpenConnection())
                {
                    if (conn == null) return false;
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@excludeID", excludeCustomerID);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Validation error: " + ex.Message);
                return false;
            }
        }

        // =====================================================
        // Static Data Access Methods (for Admin delegation)
        // =====================================================

        /// <summary>
        /// Returns all customers as a DataTable, ordered by CustomerID.
        /// Used by Admin.ViewCustomers().
        /// </summary>
        internal static DataTable GetAllCustomers()
        {
            DatabaseManager db = new DatabaseManager();
            string sql = "SELECT CustomerID, Username, FullName, Email, Phone, Address, CreatedDate " +
                         "FROM Customer ORDER BY CustomerID";
            return db.ExecuteQuery(sql);
        }

        /// <summary>
        /// Searches customers by optional name, username, email, or phone filters.
        /// Used by Admin.SearchCustomers().
        /// </summary>
        internal static DataTable SearchCustomers(string name, string username, string email, string phone)
        {
            DatabaseManager db = new DatabaseManager();
            string baseSql = "SELECT CustomerID, Username, FullName, Email, Phone, Address, CreatedDate FROM Customer WHERE 1=1 ";
            List<string> conditions = new List<string>();
            List<SQLiteParameter> parameters = new List<SQLiteParameter>();

            if (!string.IsNullOrWhiteSpace(name))
            {
                conditions.Add("FullName LIKE @name");
                parameters.Add(new SQLiteParameter("@name", "%" + name + "%"));
            }
            if (!string.IsNullOrWhiteSpace(username))
            {
                conditions.Add("Username LIKE @username");
                parameters.Add(new SQLiteParameter("@username", "%" + username + "%"));
            }
            if (!string.IsNullOrWhiteSpace(email))
            {
                conditions.Add("Email LIKE @email");
                parameters.Add(new SQLiteParameter("@email", "%" + email + "%"));
            }
            if (!string.IsNullOrWhiteSpace(phone))
            {
                conditions.Add("Phone LIKE @phone");
                parameters.Add(new SQLiteParameter("@phone", "%" + phone + "%"));
            }

            string sql = baseSql;
            if (conditions.Count > 0)
                sql += " AND " + string.Join(" AND ", conditions);
            sql += " ORDER BY CustomerID";

            DataTable dt = new DataTable();
            try
            {
                using (var conn = db.OpenConnection())
                {
                    if (conn == null) return dt;
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                        using (var adapter = new SQLiteDataAdapter(cmd))
                            adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
            return dt;
        }

        /// <summary>
        /// Returns the total number of registered customers.
        /// Used by Admin.GetTotalCustomers().
        /// </summary>
        internal static int GetTotalCustomerCount()
        {
            DatabaseManager db = new DatabaseManager();
            object result = db.ExecuteScalar("SELECT COUNT(*) FROM Customer");
            return (result == DBNull.Value) ? 0 : Convert.ToInt32(result);
        }

        /// <summary>
        /// Returns the number of customers registered in the current month.
        /// Used by Admin.GetNewCustomersThisMonth().
        /// </summary>
        internal static int GetNewCustomersThisMonthCount()
        {
            DatabaseManager db = new DatabaseManager();
            string sql = "SELECT COUNT(*) FROM Customer WHERE strftime('%Y-%m', CreatedDate) = strftime('%Y-%m', 'now')";
            object result = db.ExecuteScalar(sql);
            return (result == DBNull.Value) ? 0 : Convert.ToInt32(result);
        }

        // =====================================================
        // Checkout Coordination (PlaceOrder)
        // =====================================================

        /// <summary>
        /// Coordinates the entire checkout workflow.
        /// Returns true and a success message, or false and an error message.
        /// </summary>
        public static bool PlaceOrder(out string message)
        {
            message = string.Empty;

            // 1) Identify current customer from session
            if (SessionManager.CurrentSession == null)
            {
                message = "No active session. Please log in.";
                return false;
            }
            int customerID = SessionManager.CurrentSession.UserID;

            // 2) Access the in‑memory cart (held by CartForm)
            List<OrderItem> cartItems = CartForm.CartItems;

            // 3) Centralised cart validation (empty / invalid items)
            string cartError = ValidationHelper.ValidateCart(cartItems);
            if (cartError != null)
            {
                message = cartError;
                return false;
            }

            // 4) Iterate through cart: stock check + prescription handling
            List<int> uploadedPrescriptionIDs = new List<int>();

            foreach (OrderItem item in cartItems)
            {
                // Use the medicine helper for stock check
                if (!Medicine.HasSufficientStock(item.MedicineID, item.Quantity))
                {
                    Medicine med = Medicine.GetMedicineByID(item.MedicineID);
                    string medName = med != null ? med.MedicineName : "Unknown";
                    message = $"Insufficient stock for \"{medName}\".";
                    return false;
                }

                Medicine medicine = Medicine.GetMedicineByID(item.MedicineID);
                if (medicine == null)
                {
                    message = $"Medicine with ID {item.MedicineID} not found.";
                    return false;
                }

                // Prescription required?
                if (medicine.PrescriptionRequired)
                {
                    using (PrescriptionUploadForm uploadForm = new PrescriptionUploadForm())
                    {
                        if (uploadForm.ShowDialog() != DialogResult.OK)
                        {
                            message = "Checkout cancelled – prescription upload is required.";
                            return false;
                        }

                        string filePath = uploadForm.PrescriptionFilePath;
                        int prescID = Prescription.UploadPrescription(customerID,
                            medicine.MedicineID, filePath, out string prescError);

                        if (prescID <= 0)
                        {
                            message = string.IsNullOrEmpty(prescError)
                                ? "Failed to upload prescription for " + medicine.MedicineName + "."
                                : prescError;
                            return false;
                        }
                        uploadedPrescriptionIDs.Add(prescID);
                    }
                }
            }

            // 5) Create the order (stock reduction, DB insert)
            Order order = new Order(customerID, cartItems);
            int orderID = order.GenerateOrderRecord();
            if (orderID <= 0)
            {
                message = "Order could not be created. Please try again.";
                return false;
            }

            // 6) Link uploaded prescriptions to the order
            foreach (int prescID in uploadedPrescriptionIDs)
            {
                bool linked = Prescription.UpdateOrderID(prescID, orderID);
                if (!linked)
                {
                    // Non‑critical – order is already placed, but link failed.
                }
            }

            // 7) Clear the cart
            CartForm.ClearCart();

            message = $"Order #{orderID} placed successfully!";
            return true;
        }
    }
}