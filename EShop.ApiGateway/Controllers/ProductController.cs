using EShop.Infrastructure.Command.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EShop.ApiGateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await Task.CompletedTask;
            return Accepted("Get products method call");
        }

        [HttpPost]
        public async Task<IActionResult>Add([FromForm] CreateProduct  product)
        {
            await Task.CompletedTask;
            return Accepted("Product Created");
        }
    }
}
