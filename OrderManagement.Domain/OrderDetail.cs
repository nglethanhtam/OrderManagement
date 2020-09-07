using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement.Domain
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public virtual Product Product { get; set; }
    }
}
