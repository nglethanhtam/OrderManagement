using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement.Domain
{
    [Table("Product")]
    public class Product
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
