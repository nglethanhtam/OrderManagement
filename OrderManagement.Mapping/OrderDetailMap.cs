using OrderManagement.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OrderManagement.Mapping
{
    public class OrderDetailMap : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrderId, t.ProductId });

            // Table & Column Mappings
            this.ToTable("OrderDetail");
            this.Property(t => t.OrderId).HasColumnName("order_id");
            this.Property(t => t.ProductId).HasColumnName("product_id");
            this.Property(t => t.Quantity).HasColumnName("quantity");
            this.Property(t => t.Price).HasColumnName("price");
        }
    }
}
