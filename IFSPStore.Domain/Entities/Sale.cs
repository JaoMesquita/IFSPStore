using IFSPStore.Domain.Base;

namespace IFSPStore.Domain.Entities
{
    public class Sale : BaseEntity<int>
    {
        public Sale(int id, DateTime saleDate, double totalValue, int userId, int customerId, bool active) : base(id)
        {
            Id = id;
            SaleDate = saleDate;
            TotalValue = totalValue;
            UserId = userId;
            CustomerId = customerId;
            Active = active;
        }

        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public double TotalValue { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public bool Active { get; set; }

    }

}
