using Microsoft.AspNetCore.Mvc;
using PartsUnlimited.Server.Data;
using PartsUnlimited.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartsUnlimited.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        PartsUnlimitedContext context = new PartsUnlimitedContext();
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return context.Products.ToList(); ;
        }
    }
}
