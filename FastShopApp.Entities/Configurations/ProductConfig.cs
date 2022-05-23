using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastShopApp.Entities.Configurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.ProductName).IsRequired().HasMaxLength(150);
            builder.Property(x=>x.UnitPrice).IsRequired().HasPrecision(10,2);
            builder.Property(x=>x.Height).HasPrecision(10,2);
            builder.Property(x=>x.Width).HasPrecision(10,2);
        }
    }
}
