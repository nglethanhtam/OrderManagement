using System;

namespace OrderManagement.Shared.DTOs.Product
{
    public class ProductModificationResponse
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
