using OrderManagement.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderManagement.Service.Interfaces
{
    public interface IProductService
    {
        Task<Product> Create(Product request);
        Task<Product> Update(Product request);
        Task<IEnumerable<Product>> List();
        Task<Product> Find(Guid id);
    }
}
