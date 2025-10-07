using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Sale : BaseEntity<int>
    {
        public Sale(int id, DateTime saleDate, decimal salesTotal, User salesman, Customer customer) : base(id)
        {
            SaleDate = saleDate;
            SalesTotal = salesTotal;
            Salesman = salesman;
            Customer = customer;
            SaleItens = new List<SaleItem>();
        }

        public DateTime SaleDate { get; set; }
        public decimal SalesTotal { get; set; }
        public User Salesman { get; set; }
        public Customer Customer { get; set; }
        public List<SaleItem> SaleItens { get; set; }
    }

    public class SaleItem : BaseEntity<int>
    {
        public SaleItem(int id, Sale sale, Product product, decimal quantity, decimal unitPrice, decimal totalPrice) : base(id)
        {
            Sale = sale;
            Product = product;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = totalPrice;
        }

        public Sale Sale { get; set; }
        public Product Product { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }

}
