using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Domain;
using OrderManagement.Service.Interfaces;
using OrderManagement.Shared.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;

        public ProductController(IMapper mapper
                               , IProductService productService)
        {
            this._mapper = mapper;
            this._productService = productService;
        }

        // GET: api/Product
        [HttpGet]
        public async Task<IEnumerable<ProductViewModel>> Get()
        {
            var products = await _productService.List();
            return _mapper.Map<IEnumerable<ProductViewModel>>(products);
        }

        // GET: api/Product/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<ProductViewModel> Get(Guid id)
        {
            var product = await _productService.Find(id);
            return _mapper.Map<ProductViewModel>(product);
        }

        // POST: api/Product
        [HttpPost]
        public async Task<ProductCreationResponse> Post([FromBody] ProductCreationRequest request)
        {
            var product = _mapper.Map<Product>(request);
            var response = await _productService.Create(product);
            return _mapper.Map<ProductCreationResponse>(response);
        }

        // PUT: api/Product/5
        [HttpPut]
        public async Task<ProductModificationResponse> Put([FromBody] ProductModificationRequest request)
        {
            var product = _mapper.Map<Product>(request);
            var response = await _productService.Update(product);
            return _mapper.Map<ProductModificationResponse>(response);
        }
    }
}
