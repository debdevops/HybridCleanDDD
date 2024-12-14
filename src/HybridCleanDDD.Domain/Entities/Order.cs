namespace HybridCleanDDD.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; private set; }
        public string ProductName { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; } // Optional property for price

        // Constructor
        public Order(string productName, int quantity, decimal price)
        {
            Id = Guid.NewGuid(); // Or set this via another method if required
            ProductName = productName;
            Quantity = quantity;
            Price = price;
        }


        // Optional: Parameterless constructor (required by EF Core)
        public Order() { }

        // Method to update quantity
        public void UpdateQuantity(int quantity)
        {
            Quantity = quantity;
        }
    }
}
