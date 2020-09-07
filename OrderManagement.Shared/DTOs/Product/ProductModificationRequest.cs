using System;

namespace OrderManagement.Shared.DTOs.Product
{
    public class ProductModificationRequest
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
