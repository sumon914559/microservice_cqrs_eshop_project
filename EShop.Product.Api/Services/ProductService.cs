using EShop.Infrastructure.Command.Product;
using EShop.Infrastructure.Event.Product;
using EShop.Product.Api.Repositories;
using System;
using System.Threading.Tasks;

namespace EShop.Product.Api.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<ProductCreated> AddProduct(CreateProduct product)
        {
           // product.ProductId = Guid.NewGuid();
            return await _productRepository.AddProduct(product);
        }

        public async Task<ProductCreated> GetProduct(string ProductId)
        {
            return await _productRepository.GetProduct(ProductId);
        }
    }
}
