using Jwt_NetCore3._1.Middleware;
using Jwt_NetCore3._1.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Jwt_NetCore3._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [AuthorizeJwt]
        [HttpGet]
        public IActionResult GetProductList()
        {
            return new ObjectResult(_productService.GetAll());
        }
    }
}
