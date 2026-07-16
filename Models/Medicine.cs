using SmartMed.Managers;
using SmartMed.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SmartMed.Models
{
    internal class Medicine
    {
        // ====================================================================
        // Private Fields
        // ====================================================================
        private int medicineID;
        private string medicineName;
        private string category;
        private string dosage;
        private decimal price;
        private int stockQuantity;
        private string supplier;
        private DateTime expiryDate;
        private decimal discountPercentage;
        private bool prescriptionRequired;

        // ====================================================================
        // Public Properties
        // ====================================================================
        public int MedicineID
        {
            get { return medicineID; }
            set { medicineID = value; }
        }

        public string MedicineName
        {
            get { return medicineName; }
            set { medicineName = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public string Dosage
        {
            get { return dosage; }
            set { dosage = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public int StockQuantity
        {
            get { return stockQuantity; }
            set { stockQuantity = value; }
        }

        public string Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }

        public DateTime ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }

        public decimal DiscountPercentage
        {
            get { return discountPercentage; }
            set { discountPercentage = value; }
        }

        public bool PrescriptionRequired
        {
            get { return prescriptionRequired; }
            set { prescriptionRequired = value; }
        }

        // ====================================================================
        // Constructors
        // ====================================================================
        public Medicine()
        {
            medicineID = 0;
            medicineName = "";
            category = "";
            dosage = "";
            price = 0;
            stockQuantity = 0;
            supplier = "";
            expiryDate = DateTime.Today;
            discountPercentage = 0;
            prescriptionRequired = false;
        }

        public Medicine(int medicineID, string medicineName, string category, string dosage,
                        decimal price, int stockQuantity, string supplier, DateTime expiryDate,
                        decimal discountPercentage, bool prescriptionRequired)
        {
            this.medicineID = medicineID;
            this.medicineName = medicineName;
            this.category = category;
            this.dosage = dosage;
            this.price = price;
            this.stockQuantity = stockQuantity;
            this.supplier = supplier;
            this.expiryDate = expiryDate;
            this.discountPercentage = discountPercentage;
            this.prescriptionRequired = prescriptionRequired;
        }

        // ====================================================================
        // UML Business Methods
        // ====================================================================
        public void ApplyDiscount()
        {
            if (discountPercentage > 0)
            {
                decimal discountAmount = CalculateDiscountAmount(price, discountPercentage);
                price = price - discountAmount;
            }
        }

        public void UpdateStock(int quantityChange)
        {
            stockQuantity = stockQuantity + quantityChange;
            if (stockQuantity < 0)
            {
                stockQuantity = 0;
            }
        }

        public bool CheckExpiry()
        {
            return expiryDate < DateTime.Today;
        }

        // ====================================================================
        // NEW: Stock Check Helper (aligns with sequence diagram)
        // ====================================================================

        /// <summary>
        /// Checks if a medicine has at least the requested quantity in stock.
        /// This is a pre‑check only; the final reduction uses a guarded UPDATE.
        /// </summary>
        public static bool HasSufficientStock(int medicineID, int quantity)
        {
            Medicine med = GetMedicineByID(medicineID);
            if (med == null) return false;
            return med.StockQuantity >= quantity;
        }

        // ====================================================================
        // Internal Database Operations
        // ====================================================================

        /// <summary>
        /// Inserts a new medicine record into the database.
        /// Returns true if the insert was successful.
        /// </summary>
        internal static bool Add(Medicine med)
        {
            DatabaseManager db = new DatabaseManager();
            string sql = "INSERT INTO Medicine (MedicineName, Category, Dosage, Price, StockQuantity, Supplier, ExpiryDate, DiscountPercentage, PrescriptionRequired) " +
                         "VALUES (@name, @cat, @dosage, @price, @stock, @supplier, @expiry, @discount, @prescription)";

            try
            {
                using (var conn = db.OpenConnection())
                {
                    if (conn == null) return false;
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        BindMedicineParameters(cmd, med);
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Updates an existing medicine record in the database.
        /// Returns true if the update affected at least one row.
        /// </summary>
        internal static bool Update(Medicine med)
        {
            DatabaseManager db = new DatabaseManager();
            string sql = "UPDATE Medicine SET MedicineName=@name, Category=@cat, Dosage=@dosage, Price=@price, " +
                         "StockQuantity=@stock, Supplier=@supplier, ExpiryDate=@expiry, DiscountPercentage=@discount, " +
                         "PrescriptionRequired=@prescription WHERE MedicineID=@id";
            try
            {
                using (var conn = db.OpenConnection())
                {
                    if (conn == null) return false;
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        BindMedicineParameters(cmd, med);
                        cmd.Parameters.AddWithValue("@id", med.MedicineID);
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Deletes a medicine record by its ID.
        /// Returns true if the deletion succeeded.
        /// </summary>
        internal static bool Delete(int medicineID)
        {
            DatabaseManager db = new DatabaseManager();
            string sql = "DELETE FROM Medicine WHERE MedicineID=@id";
            try
            {
                using (var conn = db.OpenConnection())
                {
                    if (conn == null) return false;
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", medicineID);
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Reduces the stock of a medicine within an existing transaction.
        /// Returns true if the stock was successfully reduced.
        /// </summary>
        internal static bool ReduceStock(int medicineID, int quantity, SQLiteConnection conn, SQLiteTransaction transaction)
        {
            string sql = @"UPDATE Medicine SET StockQuantity = StockQuantity - @qty
                           WHERE MedicineID = @medID AND StockQuantity >= @qty";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@qty", quantity);
                cmd.Parameters.AddWithValue("@medID", medicineID);
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
        }

        /// <summary>
        /// Retrieves all medicines ordered by name.
        /// </summary>
        internal static DataTable GetAll()
        {
            DatabaseManager db = new DatabaseManager();
            return db.ExecuteQuery("SELECT * FROM Medicine ORDER BY MedicineName");
        }

        /// <summary>
        /// Searches medicines using filters for the admin panel.
        /// </summary>
        internal static DataTable Search(string name, string category, bool lowStock, bool expired, bool prescription, string sortBy)
        {
            DatabaseManager db = new DatabaseManager();
            string sql = "SELECT * FROM Medicine WHERE 1=1 ";

            if (!string.IsNullOrWhiteSpace(name))
                sql += " AND MedicineName LIKE @name ";
            if (!string.IsNullOrWhiteSpace(category) && category != "All")
                sql += " AND Category = @cat ";
            if (lowStock)
                sql += " AND StockQuantity <= 10 ";
            if (expired)
                sql += " AND ExpiryDate < date('now') ";
            if (prescription)
                sql += " AND PrescriptionRequired = 1 ";

            switch (sortBy)
            {
                case "Price": sql += " ORDER BY Price"; break;
                case "Stock": sql += " ORDER BY StockQuantity"; break;
                case "Expiry Date": sql += " ORDER BY ExpiryDate"; break;
                default: sql += " ORDER BY MedicineName"; break;
            }

            try
            {
                using (var conn = db.OpenConnection())
                {
                    if (conn == null) return new DataTable();
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(name))
                            cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                        if (!string.IsNullOrWhiteSpace(category) && category != "All")
                            cmd.Parameters.AddWithValue("@cat", category);
                        using (var adapter = new SQLiteDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }

        /// <summary>
        /// Customer-facing medicine search with price, discount, stock, and prescription filters.
        /// Applies a linear search on the medicine name and adds a FinalPrice column.
        /// </summary>
        public static DataTable SearchMedicinesForCustomer(string name, string category,
            decimal? minPrice, decimal? maxPrice, bool discountedOnly, bool prescriptionOnly,
            bool inStockOnly, string sortBy)
        {
            // 1) BUILD THE SQL QUERY (excluding name filter)
            string sql = "SELECT * FROM Medicine WHERE 1=1 ";

            if (!string.IsNullOrWhiteSpace(category) && category != "All")
                sql += " AND Category = @cat ";

            if (minPrice.HasValue || maxPrice.HasValue)
            {
                if (minPrice.HasValue && maxPrice.HasValue)
                    sql += " AND Price BETWEEN @minPrice AND @maxPrice ";
                else if (minPrice.HasValue)
                    sql += " AND Price >= @minPrice ";
                else if (maxPrice.HasValue)
                    sql += " AND Price <= @maxPrice ";
            }

            if (discountedOnly)
                sql += " AND DiscountPercentage > 0 ";

            if (prescriptionOnly)
                sql += " AND PrescriptionRequired = 1 ";

            if (inStockOnly)
                sql += " AND StockQuantity > 0 ";

            // Sorting
            switch (sortBy)
            {
                case "Medicine Name A-Z":
                    sql += " ORDER BY MedicineName ASC";
                    break;
                case "Medicine Name Z-A":
                    sql += " ORDER BY MedicineName DESC";
                    break;
                case "Price Low → High":
                    sql += " ORDER BY Price ASC";
                    break;
                case "Price High → Low":
                    sql += " ORDER BY Price DESC";
                    break;
                default:
                    sql += " ORDER BY MedicineName ASC";
                    break;
            }

            // 2) EXECUTE THE QUERY
            DatabaseManager db = new DatabaseManager();
            DataTable allMedicines = new DataTable();

            try
            {
                using (var conn = db.OpenConnection())
                {
                    if (conn == null) return allMedicines;

                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(category) && category != "All")
                            cmd.Parameters.AddWithValue("@cat", category);
                        if (minPrice.HasValue && maxPrice.HasValue)
                        {
                            cmd.Parameters.AddWithValue("@minPrice", minPrice.Value);
                            cmd.Parameters.AddWithValue("@maxPrice", maxPrice.Value);
                        }
                        else if (minPrice.HasValue)
                            cmd.Parameters.AddWithValue("@minPrice", minPrice.Value);
                        else if (maxPrice.HasValue)
                            cmd.Parameters.AddWithValue("@maxPrice", maxPrice.Value);

                        using (var adapter = new SQLiteDataAdapter(cmd))
                        {
                            adapter.Fill(allMedicines);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error while searching medicines: " + ex.Message);
                return allMedicines;
            }

            // 3) LINEAR SEARCH BY MEDICINE NAME (if name is provided)
            if (!string.IsNullOrWhiteSpace(name))
            {
                DataTable filteredTable = allMedicines.Clone();

                // Linear Search: loop through every row
                foreach (DataRow row in allMedicines.Rows)
                {
                    string medicineName = row["MedicineName"].ToString();

                    // Case-insensitive check if the name contains the search term
                    if (medicineName.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        filteredTable.ImportRow(row);
                    }
                }

                allMedicines = filteredTable;
            }

            // 4) ADD FINAL PRICE COLUMN (discount applied)
            if (!allMedicines.Columns.Contains("FinalPrice"))
                allMedicines.Columns.Add("FinalPrice", typeof(decimal));

            foreach (DataRow row in allMedicines.Rows)
            {
                decimal price = Convert.ToDecimal(row["Price"]);
                decimal discount = Convert.ToDecimal(row["DiscountPercentage"]);
                row["FinalPrice"] = ComputeFinalPrice(price, discount);
            }

            return allMedicines;
        }

        // ====================================================================
        // Internal Lookup Helpers
        // ====================================================================

        /// <summary>
        /// Returns a summary of medicine counts: total, available, low stock, expired, prescription.
        /// </summary>
        internal static Dictionary<string, int> GetSummary()
        {
            DatabaseManager db = new DatabaseManager();
            Dictionary<string, int> summary = new Dictionary<string, int>
            {
                ["Total"] = SafeGetInt(db.ExecuteScalar("SELECT COUNT(*) FROM Medicine")),
                ["Available"] = SafeGetInt(db.ExecuteScalar("SELECT COUNT(*) FROM Medicine WHERE StockQuantity > 0")),
                ["LowStock"] = SafeGetInt(db.ExecuteScalar("SELECT COUNT(*) FROM Medicine WHERE StockQuantity <= 10")),
                ["Expired"] = SafeGetInt(db.ExecuteScalar("SELECT COUNT(*) FROM Medicine WHERE ExpiryDate < date('now')")),
                ["Prescription"] = SafeGetInt(db.ExecuteScalar("SELECT COUNT(*) FROM Medicine WHERE PrescriptionRequired = 1"))
            };
            return summary;
        }

        /// <summary>
        /// Returns the number of medicines expiring within the next 'days' days.
        /// </summary>
        internal static int GetExpiringCount(int days)
        {
            DatabaseManager db = new DatabaseManager();
            string sql = $"SELECT COUNT(*) FROM Medicine WHERE date(ExpiryDate) BETWEEN date('now') AND date('now','+{days} day')";
            object result = db.ExecuteScalar(sql);
            return (result == DBNull.Value) ? 0 : Convert.ToInt32(result);
        }

        /// <summary>
        /// Returns a distinct, sorted list of all medicine categories.
        /// </summary>
        internal static List<string> GetCategories()
        {
            return GetDistinctValues("Category");
        }

        /// <summary>
        /// Returns a distinct, sorted list of all dosages.
        /// </summary>
        internal static List<string> GetDosages()
        {
            return GetDistinctValues("Dosage");
        }

        /// <summary>
        /// Returns a distinct, sorted list of all suppliers.
        /// </summary>
        internal static List<string> GetSuppliers()
        {
            return GetDistinctValues("Supplier");
        }

        /// <summary>
        /// Retrieves a single Medicine object by its database ID. Returns null if not found.
        /// </summary>
        public static Medicine GetMedicineByID(int medicineID)
        {
            DatabaseManager db = new DatabaseManager();
            string sql = "SELECT * FROM Medicine WHERE MedicineID = @id";
            try
            {
                using (var conn = db.OpenConnection())
                {
                    if (conn == null) return null;
                    using (var cmd = new SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", medicineID);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return MapFromReader(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching medicine: " + ex.Message);
            }
            return null;
        }

        /// <summary>
        /// Computes the final price after applying a discount percentage.
        /// Matches the business logic of Medicine.ApplyDiscount().
        /// </summary>
        public static decimal ComputeFinalPrice(decimal originalPrice, decimal discountPercentage)
        {
            if (discountPercentage > 0 && discountPercentage <= 100)
            {
                decimal discountAmount = CalculateDiscountAmount(originalPrice, discountPercentage);
                return originalPrice - discountAmount;
            }
            return originalPrice;
        }

        // ====================================================================
        // Private Helper Methods
        // ====================================================================

        /// <summary>
        /// Binds all common medicine parameters to a SQLiteCommand (excluding MedicineID).
        /// Used by Add and Update to avoid duplication.
        /// </summary>
        private static void BindMedicineParameters(SQLiteCommand cmd, Medicine med)
        {
            cmd.Parameters.AddWithValue("@name", med.MedicineName);
            cmd.Parameters.AddWithValue("@cat", med.Category);
            cmd.Parameters.AddWithValue("@dosage", med.Dosage);
            cmd.Parameters.AddWithValue("@price", med.Price);
            cmd.Parameters.AddWithValue("@stock", med.StockQuantity);
            cmd.Parameters.AddWithValue("@supplier", med.Supplier);
            cmd.Parameters.AddWithValue("@expiry", med.ExpiryDate.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@discount", med.DiscountPercentage);
            cmd.Parameters.AddWithValue("@prescription", med.PrescriptionRequired ? 1 : 0);
        }

        /// <summary>
        /// Maps a SqliteDataReader row to a Medicine object.
        /// </summary>
        private static Medicine MapFromReader(SQLiteDataReader reader)
        {
            return new Medicine(
                Convert.ToInt32(reader["MedicineID"]),
                reader["MedicineName"].ToString(),
                reader["Category"].ToString(),
                reader["Dosage"].ToString(),
                Convert.ToDecimal(reader["Price"]),
                Convert.ToInt32(reader["StockQuantity"]),
                reader["Supplier"].ToString(),
                Convert.ToDateTime(reader["ExpiryDate"]),
                Convert.ToDecimal(reader["DiscountPercentage"]),
                Convert.ToBoolean(reader["PrescriptionRequired"])
            );
        }

        /// <summary>
        /// Returns the integer value of an ExecuteScalar result, or 0 if DBNull.
        /// </summary>
        private static int SafeGetInt(object value)
        {
            return value == DBNull.Value ? 0 : Convert.ToInt32(value);
        }

        /// <summary>
        /// Returns a sorted list of distinct values for a given column in the Medicine table.
        /// </summary>
        private static List<string> GetDistinctValues(string columnName)
        {
            DatabaseManager db = new DatabaseManager();
            string sql = $"SELECT DISTINCT {columnName} FROM Medicine ORDER BY {columnName}";
            DataTable dt = db.ExecuteQuery(sql);
            List<string> list = new List<string>();
            foreach (DataRow row in dt.Rows)
                list.Add(row[columnName].ToString());
            return list;
        }

        /// <summary>
        /// Calculates the discount amount for a given price and discount percentage.
        /// </summary>
        private static decimal CalculateDiscountAmount(decimal price, decimal discountPercentage)
        {
            return price * discountPercentage / 100;
        }
    }
}