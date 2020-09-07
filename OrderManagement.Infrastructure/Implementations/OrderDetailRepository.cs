using OrderManagement.Domain;
using OrderManagement.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManagement.Infrastructure.Implementations
{
    public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(IMongoContext context) : base(context)
        {
        }
    }
}
