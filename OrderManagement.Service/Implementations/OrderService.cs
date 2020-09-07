using OrderManagement.Domain;
using OrderManagement.Infrastructure.Interfaces;
using OrderManagement.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderManagement.Service.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OrderService(IOrderRepository orderRepository
                          , IOrderDetailRepository orderDetailRepository
                          , IUnitOfWork unitOfWork)
        {
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Order> Create(IEnumerable<OrderDetail> request)
        {
            var orderId = Guid.NewGuid();
            request.ToList().ForEach(item => { item.OrderId = orderId; });
            await _orderDetailRepository.AddRange(request);

            var order = new Order
            {
                OrderId = orderId,
                TotalAmount = request.Sum(item => item.Quantity * item.Price),
                CreatedDate = DateTime.UtcNow,
                OrderDetails = request
            };
            await _orderRepository.Add(order);

            bool isSuccess = _unitOfWork.Commit();
            return isSuccess ? order : null;
        }

        public async Task<IEnumerable<Order>> List()
        {
            return await _orderRepository.GetAll();
        }
    }
}
