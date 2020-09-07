using OrderManagement.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OrderManagement.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ProductId });

            // Table & Column Mappings
            this.ToTable("Product");
            this.Property(t => t.ProductId).HasColumnName("id");
            this.Property(t => t.ProductName).HasColumnName("name");
            this.Property(t => t.Price).HasColumnName("price");
        }
    }
}
