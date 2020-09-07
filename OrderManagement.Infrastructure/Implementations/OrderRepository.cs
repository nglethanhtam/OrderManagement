using OrderManagement.Domain;
using OrderManagement.Infrastructure.Interfaces;

namespace OrderManagement.Infrastructure.Implementations
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(IMongoContext context) : base(context)
        {
        }
    }
}
