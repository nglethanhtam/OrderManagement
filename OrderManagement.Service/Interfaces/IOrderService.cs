using OrderManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Service.Interfaces
{
    public interface IOrderService
    {
        Task<Order> Create(IEnumerable<OrderDetail> request);
        Task<IEnumerable<Order>> List();
    }
}
