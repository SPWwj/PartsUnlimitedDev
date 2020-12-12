using Microsoft.AspNetCore.Mvc;
using PartsUnlimited.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartsUnlimited.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarouselController : Controller
    {
        [HttpGet]
        public IEnumerable<Carousel> Get()
        {
            var x = new List<Carousel>() {
                new Carousel
                {
                    Id=1,
                    Name="Macbook",
                    Img="/images/promo/macbook-new.jpg"
                },
                new Carousel
                {
                    Id=2,
                    Name="Iphone",
                    Img="/images/promo/iphone.jpg"
                },
                new Carousel
                {
                    Id=3,
                    Name="Ipad",
                    Img="/images/promo/ipad.jpg"
                }
            };


            return x.ToArray();
        }
    }
}
