namespace SmartMed.Models
{
    internal class OrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int MedicineID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        // Default constructor
        public OrderItem()
        {
            OrderItemID = 0;
            OrderID = 0;
            MedicineID = 0;
            Quantity = 0;
            UnitPrice = 0.0m;
        }

        // Constructor used when building a new order (OrderID is not known yet)
        public OrderItem(int medicineID, int quantity, decimal unitPrice)
        {
            MedicineID = medicineID;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        // Calculate the line total for this item
        public decimal CalculateSubtotal()
        {
            return Quantity * UnitPrice;
        }
    }
}