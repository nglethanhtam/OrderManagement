using OrderManagement.Shared.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Shared.DTOs.Order
{
    public class OrderCreationRequest
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
