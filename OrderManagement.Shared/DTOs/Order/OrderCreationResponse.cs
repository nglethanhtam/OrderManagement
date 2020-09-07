using OrderManagement.Shared.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Shared.DTOs.Order
{
    public class OrderCreationResponse
    {
        public Guid OrderId { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual IEnumerable<OrderCreationRequest> OrderDetails { get; set; }
    }
}
