using System;

namespace G_36_SmartPrint.BL
{
    internal class ConsumableInventoryBL
    {
        // Properties with encapsulation
        public int ItemId { get; private set; }
        public string ItemName { get; private set; }
        public int CurrentStock { get; private set; }

        // Constructor to initialize all properties
        public ConsumableInventoryBL(int itemId, string itemName, int currentStock)
        {
            ItemId = itemId;
            ItemName = itemName;
            CurrentStock = currentStock;
        }

        // Method to update stock
        public void UpdateStock(int newStock)
        {
            if (newStock < 0)
                throw new ArgumentException("Stock cannot be negative.");
            CurrentStock = newStock;
        }

        // Optional: Method to rename the item
        public void RenameItem(string newName)
        {
            if (string.IsNullOrWhiteSpace(newName))
                throw new ArgumentException("Item name cannot be empty.");
            ItemName = newName;
        }

        // Optional: Method to set a new item ID (if needed)
        public void SetItemId(int newId)
        {
            if (newId <= 0)
                throw new ArgumentException("Item ID must be positive.");
            ItemId = newId;
        }
    }
}
