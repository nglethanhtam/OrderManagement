using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Domain;
using OrderManagement.Service.Interfaces;
using OrderManagement.Shared.DTOs.Order;

namespace OrderManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IOrderService _orderService;

        public OrderController(IMapper mapper
                             , IOrderService orderService)
        {
            this._mapper = mapper;
            this._orderService = orderService;
        }

        // GET: api/Order
        [HttpGet]
        public async Task<IEnumerable<OrderViewModel>> Get()
        {
            var orders = await _orderService.List();
            return _mapper.Map<IEnumerable<OrderViewModel>>(orders);
        }

        // POST: api/Order
        [HttpPost]
        public async Task<OrderCreationResponse> Post([FromBody] IEnumerable<OrderCreationRequest> request)
        {
            var orderDetail = _mapper.Map<IEnumerable<OrderDetail>>(request);
            var response = await _orderService.Create(orderDetail);
            return _mapper.Map<OrderCreationResponse>(response);
        }
    }
}
