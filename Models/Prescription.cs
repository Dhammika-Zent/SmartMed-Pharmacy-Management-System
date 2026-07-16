using System;
using System.IO;
using SmartMed.Managers;      // DatabaseManager
using SmartMed.Helpers;       // ValidationHelper

namespace SmartMed.Models
{
    internal class Prescription
    {
        // =====================================================
        // Properties
        // =====================================================
        public int PrescriptionID { get; set; }
        public int CustomerID { get; set; }
        public int MedicineID { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadDate { get; set; }
        public int? OrderID { get; set; }   // NULL until linked to an order

        // =====================================================
        // Upload & Save (static – called by Customer)
        // =====================================================

        /// <summary>
        /// Uploads a prescription: validates, copies file, and saves the record.
        /// Returns the new PrescriptionID (positive) on success, or -1 on failure.
        /// If failure occurs, errorMessage contains the reason.
        /// </summary>
        public static int UploadPrescription(int customerID, int medicineID,
                                             string sourceFilePath, out string errorMessage)
        {
            errorMessage = null;

            // 1) Validate the file
            string validationError = ValidatePrescription(sourceFilePath);
            if (validationError != null)
            {
                errorMessage = validationError;
                return -1;
            }

            // 2) Copy file to application folder
            string destPath;
            if (!CopyPrescriptionFile(sourceFilePath, out destPath, out string copyError))
            {
                errorMessage = copyError;
                return -1;
            }

            // 3) Save the record (without OrderID yet)
            int prescriptionID = SavePrescription(customerID, medicineID, destPath);
            if (prescriptionID <= 0)
            {
                // If save fails, delete the copied file to avoid orphaned files
                try { File.Delete(destPath); } catch { }
                errorMessage = "Failed to save prescription record to database.";
                return -1;
            }

            return prescriptionID;
        }

        /// <summary>
        /// Validates a prescription file using ValidationHelper.
        /// Returns an error message if invalid, otherwise null.
        /// </summary>
        public static string ValidatePrescription(string filePath)
        {
            return ValidationHelper.ValidatePrescriptionFile(filePath);
        }

        /// <summary>
        /// Copies the prescription file to the application's Prescriptions folder
        /// with a unique name. Returns true on success, along with the destination path.
        /// </summary>
        private static bool CopyPrescriptionFile(string sourceFilePath,
                                                 out string destPath, out string errorMessage)
        {
            destPath = null;
            errorMessage = null;

            string destFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Prescriptions");
            Directory.CreateDirectory(destFolder);

            string uniqueName = $"{DateTime.Now:yyyyMMddHHmmss}_{Path.GetFileName(sourceFilePath)}";
            destPath = Path.Combine(destFolder, uniqueName);

            try
            {
                File.Copy(sourceFilePath, destPath, overwrite: true);
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = "Failed to copy prescription file: " + ex.Message;
                return false;
            }
        }

        /// <summary>
        /// Inserts a prescription record into the database.
        /// Returns the new PrescriptionID, or -1 on failure.
        /// </summary>
        private static int SavePrescription(int customerID, int medicineID, string filePath)
        {
            DatabaseManager db = new DatabaseManager();
            string sql = @"INSERT INTO Prescription (CustomerID, MedicineID, FilePath, UploadDate)
                           VALUES (@custID, @medID, @filePath, @uploadDate);
                           SELECT last_insert_rowid();";

            try
            {
                using (var conn = db.OpenConnection())
                {
                    if (conn == null) return -1;
                    using (var cmd = new System.Data.SQLite.SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@custID", customerID);
                        cmd.Parameters.AddWithValue("@medID", medicineID);
                        cmd.Parameters.AddWithValue("@filePath", filePath);
                        cmd.Parameters.AddWithValue("@uploadDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        object result = cmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                            return Convert.ToInt32(result);
                    }
                }
            }
            catch
            {
                // No MessageBox – caller handles failure
            }
            return -1;
        }

        /// <summary>
        /// Links a prescription to an order after the order is created.
        /// Returns true if the update succeeded.
        /// </summary>
        public static bool UpdateOrderID(int prescriptionID, int orderID)
        {
            DatabaseManager db = new DatabaseManager();
            string sql = "UPDATE Prescription SET OrderID = @orderID WHERE PrescriptionID = @prescID";

            try
            {
                using (var conn = db.OpenConnection())
                {
                    if (conn == null) return false;
                    using (var cmd = new System.Data.SQLite.SQLiteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@orderID", orderID);
                        cmd.Parameters.AddWithValue("@prescID", prescriptionID);
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}