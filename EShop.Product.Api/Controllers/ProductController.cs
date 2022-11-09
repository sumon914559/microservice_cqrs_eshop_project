using EShop.Infrastructure.Command.Product;
using EShop.Product.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EShop.Product.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService service)
        {
            _productService = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get (string ProductId)
        {
            var product = await _productService.GetProduct(ProductId);
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Add ([FromForm] CreateProduct createProduct)
        {
           var addProduct =  await _productService.AddProduct(createProduct);
            return Ok(addProduct);
        }

    }
}
