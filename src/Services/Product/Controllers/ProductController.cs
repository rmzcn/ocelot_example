using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Product.Repository;

namespace Product.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ProductEntity> Get()
        {
            return FakeRepo.GetProducts();
        }

        [HttpGet]
        [Route("{id}")]
        public IEnumerable<ProductEntity> GetById(int id)
        {
            return FakeRepo.GetProducts()
                    .Where(p => p.Id == id);
        }
    }
}
