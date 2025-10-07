using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Product : BaseEntity<int>
    {

        public Product(int id, string name, decimal price, decimal quantity, DateTime purchaseDate, string salesUnity, Category category):base(id)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            PurchaseDate = purchaseDate;
            SalesUnity = salesUnity;
            Category = category;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string SalesUnity { get; set; }
        public Category Category { get; set; }

    }
}
