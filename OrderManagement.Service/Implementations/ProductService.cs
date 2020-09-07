using OrderManagement.Domain;
using OrderManagement.Infrastructure.Interfaces;
using OrderManagement.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderManagement.Service.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository
                            , IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Product> Create(Product request)
        {
            request.ProductId = Guid.NewGuid();
            await _productRepository.Add(request);
            bool isSuccess = _unitOfWork.Commit();
            return isSuccess ? request : null;
        }

        public async Task<Product> Find(Guid id)
        {
            return await _productRepository.GetById(id);
        }

        public async Task<IEnumerable<Product>> List()
        {
            return await _productRepository.GetAll();
        }

        public async Task<Product> Update(Product request)
        {
            await _productRepository.Update(request);
            bool isSuccess = _unitOfWork.Commit();
            return isSuccess ? request : null;
        }
    }
}
