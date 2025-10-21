using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFSPStore.Repository.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(prop => prop.Price);
            builder.Property(prop => prop.Quantity);
            builder.Property(prop => prop.SalesUnit)
                .HasMaxLength(10);
            builder.HasOne( prop => prop.Category)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
