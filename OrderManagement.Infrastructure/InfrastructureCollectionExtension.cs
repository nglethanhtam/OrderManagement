using Microsoft.Extensions.DependencyInjection;
using OrderManagement.Infrastructure.Implementations;
using OrderManagement.Infrastructure.Interfaces;

namespace OrderManagement.Infrastructure
{
    public static class InfrastructureCollectionExtension
    {
        public static IServiceCollection AddInfrastructureCollection(this IServiceCollection services)
        {
            services.AddScoped<IMongoContext, MongoContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            return services;
        }

    }
}
