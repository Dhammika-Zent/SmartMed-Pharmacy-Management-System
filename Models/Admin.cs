using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SmartMed.Managers;
using SmartMed.Helpers;
using SmartMed.Forms;

namespace SmartMed.Models
{
    internal class Admin : User
    {
        // =====================================================
        // Private Fields
        // =====================================================
        private int adminID;

        // =====================================================
        // Public Properties
        // =====================================================
        public int AdminID
        {
            get { return adminID; }
            set { adminID = value; }
        }

        // =====================================================
        // Constructors
        // =====================================================
        public Admin() : base()
        {
            adminID = 0;
        }

        public Admin(int adminID, int userID, string username, string password, string fullName, string email)
            : base(userID, username, password, fullName, email)
        {
            this.adminID = adminID;
        }

        // =====================================================
        // Authentication
        // =====================================================
        public override bool Login()
        {
            string safeUsername = this.Username.Replace("'", "''");
            string safePassword = this.Password.Replace("'", "''");

            DatabaseManager db = new DatabaseManager();
            string sql = $"SELECT AdminID, Username, FullName FROM Admin " +
                         $"WHERE Username = '{safeUsername}' AND Password = '{safePassword}'";
            DataTable dt = db.ExecuteQuery(sql);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                int userId = Convert.ToInt32(row["AdminID"]);
                string user = row["Username"].ToString();
                string fullName = row["FullName"].ToString();

                SessionManager session = new SessionManager();
                session.StartSession(userId, user, fullName, "Admin");

                return true;
            }
            return false;
        }

        public override void Logout()
        {
            if (SessionManager.CurrentSession != null)
            {
                SessionManager.CurrentSession.EndSession();
            }
        }

        // =====================================================
        // Medicine Management (delegates to Medicine)
        // =====================================================
        public bool AddMedicine(Medicine med) => Medicine.Add(med);
        public bool UpdateMedicine(Medicine med) => Medicine.Update(med);
        public bool DeleteMedicine(int medicineID) => Medicine.Delete(medicineID);
        public DataTable ViewMedicines() => Medicine.GetAll();

        public DataTable SearchMedicines(string name, string category, bool lowStock, bool expired, bool prescription, string sortBy)
        {
            return Medicine.Search(name, category, lowStock, expired, prescription, sortBy);
        }

        public DataTable LinearSearchByName(string searchName)
        {
            DataTable allMeds = Medicine.GetAll();
            DataTable resultTable = allMeds.Clone();
            string lowerSearch = string.IsNullOrEmpty(searchName) ? "" : searchName.ToLower();
            foreach (DataRow row in allMeds.Rows)
            {
                if (row["MedicineName"].ToString().ToLower().Contains(lowerSearch))
                    resultTable.ImportRow(row);
            }
            return resultTable;
        }

        public Dictionary<string, int> GetMedicineSummary() => Medicine.GetSummary();
        public List<string> GetCategories() => Medicine.GetCategories();
        public List<string> GetDosages() => Medicine.GetDosages();
        public List<string> GetSuppliers() => Medicine.GetSuppliers();

        // =====================================================
        // Customer Management
        // =====================================================
        public DataTable ViewCustomers() => Customer.GetAllCustomers();
        public DataTable SearchCustomers(string name, string username, string email, string phone)
            => Customer.SearchCustomers(name, username, email, phone);
        public bool UpdateCustomer(Customer customer) => Customer.UpdateCustomerRecord(customer);
        public bool IsCustomerEmailDuplicate(string email, int excludeCustomerID) => Customer.IsEmailDuplicate(email, excludeCustomerID);
        public int GetTotalCustomers() => Customer.GetTotalCustomerCount();
        public int GetNewCustomersThisMonth() => Customer.GetNewCustomersThisMonthCount();

        // =====================================================
        // Order Management (FR-25 & FR-26)
        // =====================================================

        /// <summary>
        /// Returns all orders (FR-25). Delegates to Order class.
        /// </summary>
        public DataTable ViewOrders()
        {
            return Order.GetAllOrders();
        }

        /// <summary>
        /// Searches orders based on filters.
        /// </summary>
        public DataTable SearchOrders(string customer, string orderId, string status)
        {
            return Order.SearchOrders(customer, orderId, status);
        }

        /// <summary>
        /// Updates an order’s status (FR-26). Delegates validation and persistence to Order.
        /// </summary>
        public bool UpdateOrderStatus(int orderId, string newStatus)
        {
            return Order.UpdateOrderStatus(orderId, newStatus);
        }

        // =====================================================
        // Reporting & Dashboard (updated)
        // =====================================================
        public void GenerateReports()
        {
            // Open the reporting window (only accessible to admin)
            ReportForm reportForm = new ReportForm();
            reportForm.ShowDialog();
        }


        public class DashboardData
        {
            public int TotalMedicines { get; set; }
            public int AvailableMedicines { get; set; }
            public int LowStockMedicines { get; set; }
            public int ExpiredMedicines { get; set; }
            public int ExpiringMedicines { get; set; }
            public int PrescriptionOnlyMedicines { get; set; }
            public int TotalCustomers { get; set; }
            public int NewCustomersThisMonth { get; set; }
            public int TotalOrders { get; set; }
            public int ActiveOrders { get; set; }
            public decimal TotalSales { get; set; }
        }

        public DashboardData ViewDashboard()
        {
            Dictionary<string, int> medSummary = Medicine.GetSummary();
            int expiringCount = Medicine.GetExpiringCount(30);

            int totalCustomers = Customer.GetTotalCustomerCount();
            int newCustomers = Customer.GetNewCustomersThisMonthCount();

            DashboardData data = new DashboardData
            {
                TotalMedicines = medSummary["Total"],
                AvailableMedicines = medSummary["Available"],
                LowStockMedicines = medSummary["LowStock"],
                ExpiredMedicines = medSummary["Expired"],
                ExpiringMedicines = expiringCount,
                PrescriptionOnlyMedicines = medSummary["Prescription"],
                TotalCustomers = totalCustomers,
                NewCustomersThisMonth = newCustomers,
                TotalOrders = 0,
                ActiveOrders = 0,
                TotalSales = 0m
            };

            return data;
        }
    }
}