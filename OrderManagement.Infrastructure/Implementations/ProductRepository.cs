using OrderManagement.Domain;
using OrderManagement.Infrastructure.Interfaces;

namespace OrderManagement.Infrastructure.Implementations
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(IMongoContext context) : base(context)
        {
        }
    }
}
