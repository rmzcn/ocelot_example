using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Customer.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<CustomerEntity> Get()
        {
            return FakeRepo.GetCustomers();
        }

        [HttpGet]
        [Route("{id}")]
        public IEnumerable<CustomerEntity> GetById(int id)
        {
            return FakeRepo.GetCustomers()
                    .Where(p => p.Id == id);
        }
    }
}
