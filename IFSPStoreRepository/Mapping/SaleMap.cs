using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class SaleMap : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.ToTable("Sale");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.SaleDate)
                .IsRequired();
            builder.Property(prop => prop.SaleTotal)
                .IsRequired();
            builder.HasOne(prop => prop.Salesman)
                .WithMany()
                .HasForeignKey("SalesmanId")
                .HasConstraintName("FK_Sale_User_IFSP"); //relacionamento
            builder.HasOne(prop => prop.Customer)
                .WithMany()
                .HasForeignKey("CustomerId")
                .HasConstraintName("FK_Sale_Customer_IFSP"); //relacionamento
            builder.HasMany(prop => prop.SaleItens)
                .WithOne(prop => prop.Sale)
                .OnDelete(DeleteBehavior.Cascade);
        }

       public class SaleItemMap : IEntityTypeConfiguration<SaleItem>
        {
            public void Configure(EntityTypeBuilder<SaleItem> builder)
            {
                builder.ToTable("SaleItem");
                builder.HasKey(prop => prop.Id);
                builder.Property(prop => prop.Quantity)
                    .IsRequired();
                builder.Property(prop => prop.UnitPrice)
                    .IsRequired();
                builder.Property(prop => prop.TotalPrice)
                    .IsRequired();
                builder.HasOne(prop => prop.Sale)
                    .WithMany(prop => prop.SaleItens)
                    .OnDelete(DeleteBehavior.Cascade);
            }
        } 
    }
}
