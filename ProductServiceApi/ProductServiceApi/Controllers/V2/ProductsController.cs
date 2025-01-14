using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApi.Service;
using ProductServiceApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductServiceApi.Controllers.V2
{

    // Version 2.0 of the API
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/products")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts(
            int pageNumber = 1,
            int pageSize = 3)
        {
            var products = await _productService.GetPaginatedProducts(pageNumber, pageSize);
            return Ok(new
            {
                TotalCount = await _productService.GetTotalProductCount(),
                Products = products
            });
        }
    }
}
