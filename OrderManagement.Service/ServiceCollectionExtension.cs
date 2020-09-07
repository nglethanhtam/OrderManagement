using Microsoft.Extensions.DependencyInjection;
using OrderManagement.Service.Implementations;
using OrderManagement.Service.Interfaces;

namespace OrderManagement.Service
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddServiceCollection(this IServiceCollection services)
        {
            //Business Services
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IProductService, ProductService>();

            return services;
        }
    }
}
