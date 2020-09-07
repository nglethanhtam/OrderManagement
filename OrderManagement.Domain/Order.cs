using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement.Domain
{
    [Table("Order")]
    public class Order
    {
        public Guid OrderId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
