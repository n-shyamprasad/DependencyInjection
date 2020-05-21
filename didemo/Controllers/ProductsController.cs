using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using didemo.Services;

namespace didemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
  {
    private readonly IProductsService _productsService;
    public ProductsController(IProductsService productsService) {
      _productsService = productsService;
    }

    [HttpGet]
    public IEnumerable<Product> GetProducts() 
    {
      return _productsService.GetProducts();
    }
  }

}