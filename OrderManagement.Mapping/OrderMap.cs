using OrderManagement.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OrderManagement.Mapping
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OrderId });

            // Table & Column Mappings
            this.ToTable("Order");
            this.Property(t => t.OrderId).HasColumnName("id");
            this.Property(t => t.OrderDate).HasColumnName("order_date");
            this.Property(t => t.TotalAmount).HasColumnName("total_amount");
        }
    }
}
