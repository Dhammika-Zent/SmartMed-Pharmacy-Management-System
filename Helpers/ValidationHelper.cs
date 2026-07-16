using System;
using System.Collections.Generic;   // for List<>
using System.Linq;

namespace SmartMed.Helpers
{
    internal static class ValidationHelper
    {
        // =====================================================
        // Allowed email domains (SmartMed only)
        // =====================================================
        private static readonly string[] AllowedDomains = { "smartmed.com", "smartmed.lk" };

        // =====================================================
        // General Validation Methods
        // =====================================================

        /// <summary>
        /// Checks that a string is not null or empty.
        /// </summary>
        public static bool IsRequired(string value, string errorMessageIfEmpty, out string errorMessage)
        {
            if (string.IsNullOrEmpty(value))
            {
                errorMessage = errorMessageIfEmpty;
                return false;
            }
            errorMessage = null;
            return true;
        }

        /// <summary>
        /// Proper email validation: format + SmartMed domain check.
        /// </summary>
        public static bool IsValidEmail(string email, out string errorMessage)
        {
            if (string.IsNullOrEmpty(email))
            {
                errorMessage = "Please enter a valid email address.";
                return false;
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                string host = addr.Host;

                // 1. Must contain a dot (basic domain check)
                if (!host.Contains("."))
                {
                    errorMessage = "Please enter a valid email address.";
                    return false;
                }

                // 2. Must end with an allowed SmartMed domain (case-insensitive)
                bool domainOk = AllowedDomains.Any(d =>
                    host.EndsWith(d, StringComparison.OrdinalIgnoreCase));
                if (!domainOk)
                {
                    errorMessage = "Email must belong to a SmartMed domain (smartmed.com or smartmed.lk).";
                    return false;
                }

                errorMessage = null;
                return true;
            }
            catch
            {
                errorMessage = "Please enter a valid email address.";
                return false;
            }
        }

        /// <summary>
        /// Validates Sri Lankan phone number: digits only, exactly 10 digits,
        /// no letters, symbols or spaces.
        /// </summary>
        public static bool IsValidPhone(string phone, out string errorMessage)
        {
            if (string.IsNullOrEmpty(phone))
            {
                errorMessage = "Please enter a valid phone number.";
                return false;
            }

            if (phone.Length != 10 || !phone.All(char.IsDigit))
            {
                errorMessage = "Please enter a valid 10-digit phone number (numbers only).";
                return false;
            }

            errorMessage = null;
            return true;
        }

        /// <summary>
        /// Validates password strength: minimum 6 characters.
        /// </summary>
        public static bool IsValidPassword(string password, out string errorMessage)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 6)
            {
                errorMessage = "Password must be at least 6 characters long.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        /// <summary>
        /// Validates that two passwords match.
        /// </summary>
        public static bool IsPasswordMatch(string password, string confirmPassword, out string errorMessage)
        {
            if (!string.Equals(password, confirmPassword))
            {
                errorMessage = "Passwords do not match.";
                return false;
            }
            errorMessage = null;
            return true;
        }

        // =====================================================
        // Unchanged numeric validators (preserved)
        // =====================================================
        public static bool IsPositiveDecimal(decimal value, string errorMessageIfNotPositive, out string errorMessage)
        {
            if (value <= 0)
            {
                errorMessage = errorMessageIfNotPositive;
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool IsNonNegativeInteger(int value, string errorMessageIfNegative, out string errorMessage)
        {
            if (value < 0)
            {
                errorMessage = errorMessageIfNegative;
                return false;
            }
            errorMessage = null;
            return true;
        }

        public static bool IsInRange(decimal value, decimal min, decimal max, string errorMessageIfOutOfRange, out string errorMessage)
        {
            if (value < min || value > max)
            {
                errorMessage = errorMessageIfOutOfRange;
                return false;
            }
            errorMessage = null;
            return true;
        }

        // =====================================================
        // Medicine Validation
        // =====================================================

        /// <summary>
        /// Validates all required fields of a Medicine object.
        /// Returns the first error message if validation fails, or null if the medicine is valid.
        /// This method only performs value checks and does not access the database.
        /// </summary>
        /// <param name="medicine">The Medicine object to validate.</param>
        /// <returns>An error message string, or null if valid.</returns>
        public static string ValidateMedicine(Models.Medicine medicine)
        {
            string error;

            if (!IsRequired(medicine.MedicineName, "Medicine name is required.", out error))
                return error;
            if (!IsRequired(medicine.Category, "Category is required.", out error))
                return error;
            if (!IsRequired(medicine.Dosage, "Dosage is required.", out error))
                return error;
            if (!IsRequired(medicine.Supplier, "Supplier is required.", out error))
                return error;
            if (!IsPositiveDecimal(medicine.Price, "Price must be greater than zero.", out error))
                return error;
            if (!IsNonNegativeInteger(medicine.StockQuantity, "Stock quantity cannot be negative.", out error))
                return error;
            if (!IsInRange(medicine.DiscountPercentage, 0, 100, "Discount must be between 0 and 100.", out error))
                return error;

            return null; // valid
        }

        // =====================================================
        // Order Module Validation
        // =====================================================

        private static readonly string[] AllowedOrderStatuses = { "Pending", "Ready for Pickup", "Delivered" };

        /// <summary>
        /// Validates an order status against the allowed list.
        /// Returns an error message if the status is invalid, otherwise null.
        /// </summary>
        public static string ValidateOrderStatus(string status)
        {
            if (string.IsNullOrEmpty(status))
                return "Order status cannot be empty.";

            if (!AllowedOrderStatuses.Contains(status))
                return "Invalid order status. Allowed values: Pending, Ready for Pickup, Delivered.";

            return null; // valid
        }

        /// <summary>
        /// Validates a single OrderItem.
        /// Returns an error message if the item is invalid, otherwise null.
        /// </summary>
        public static string ValidateOrderItem(Models.OrderItem item)
        {
            if (item == null)
                return "Order item is missing.";

            if (item.Quantity <= 0)
                return "Quantity must be greater than zero.";

            if (item.UnitPrice <= 0)
                return "Unit price must be greater than zero.";

            if (item.MedicineID <= 0)
                return "Medicine ID is invalid.";

            return null; // valid
        }

        /// <summary>
        /// Validates an entire Order object.
        /// Returns the first error message if any validation rule fails, otherwise null.
        /// Does NOT check database existence – only value checks.
        /// </summary>
        public static string ValidateOrder(Models.Order order)
        {
            if (order == null)
                return "Order object is null.";

            if (order.CustomerID <= 0)
                return "Customer ID is invalid.";

            if (order.Items == null || order.Items.Count == 0)
                return "Order must contain at least one item.";

            foreach (var item in order.Items)
            {
                string itemError = ValidateOrderItem(item);
                if (itemError != null)
                    return itemError;
            }

            // Optional: validate total amount if already set (should not be negative)
            if (order.TotalAmount < 0)
                return "Total amount cannot be negative.";

            // Validate order status if it is set (allow it to be empty for new orders)
            if (!string.IsNullOrEmpty(order.OrderStatus))
            {
                string statusError = ValidateOrderStatus(order.OrderStatus);
                if (statusError != null)
                    return statusError;
            }

            return null; // valid
        }

        // =====================================================
        // Prescription File Validation (added for checkout)
        // =====================================================

        /// <summary>
        /// Validates a prescription file path.
        /// Returns an error message if invalid, otherwise null.
        /// </summary>
        public static string ValidatePrescriptionFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
                return "No file selected. Please select a prescription file.";

            if (!System.IO.File.Exists(filePath))
                return "The selected file does not exist.";

            string extension = System.IO.Path.GetExtension(filePath).ToLower();
            string[] allowed = { ".pdf", ".jpg", ".jpeg", ".png" };
            if (!allowed.Contains(extension))
                return "Unsupported file format. Allowed: PDF, JPG, PNG.";

            return null; // valid
        }

        // =====================================================
        // Cart Validation (centralised)
        // =====================================================

        /// <summary>
        /// Validates the entire shopping cart.
        /// Returns an error message if the cart is empty or any item is invalid,
        /// otherwise null.
        /// </summary>
        public static string ValidateCart(List<Models.OrderItem> cartItems)
        {
            if (cartItems == null || cartItems.Count == 0)
                return "Your cart is empty.";

            foreach (var item in cartItems)
            {
                string itemError = ValidateOrderItem(item);
                if (itemError != null)
                    return itemError;
            }
            return null; // cart is valid
        }
    }
}