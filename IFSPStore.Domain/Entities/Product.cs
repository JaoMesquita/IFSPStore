using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Product : BaseEntity<int>
    {

        public Product(int id, string name, double price, int amount, DateTime purchaseDate, string unitSale, int GroupId):base(id)
        {
            Id = id;
            Name = name;
            Price = price;
            Amount = amount;
            PurchaseDate = purchaseDate;
            UnitSale = unitSale;
            GroupId = groupId;
        }

        public int id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string UnitSale { get; set; }
        public int groupId { get; set; }

    }
}
