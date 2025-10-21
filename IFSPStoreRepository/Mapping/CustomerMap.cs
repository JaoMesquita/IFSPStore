using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
            public void Configure(EntityTypeBuilder<Customer> builder)
            {
                builder.ToTable("Customer");
                builder.HasKey(prop => prop.Id);
                builder.Property(prop => prop.Name)
                    .IsRequired()
                    .HasMaxLength(100);
                builder.Property(prop => prop.Address)
                    .IsRequired();
                builder.Property(prop => prop.Document)
                    .IsRequired();
                builder.Property(prop => prop.District)
                    .IsRequired();
            builder.HasOne(prop => prop.City)
                    .WithMany()
                    .OnDelete(DeleteBehavior.Cascade);
        }
        }
}
