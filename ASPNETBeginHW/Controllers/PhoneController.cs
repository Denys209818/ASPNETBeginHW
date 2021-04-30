using ASPNETBeginLib.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETBeginHW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetDataPhones() 
        {
            List<PhoneVM> list = new List<PhoneVM> { 
                new PhoneVM 
                {
                    brand = "Apple",
                    model = "Iphone 11 pro max",
                    price = 30000,
                    color = ColorPhone.Greed,
                    image = "http://192.168.56.101/img/1.jpg"
                },
                new PhoneVM 
                {
                    brand = "Samsung",
                    model = "Note 10",
                    price = 30000,
                    color = ColorPhone.Silver,
                    image = "http://192.168.56.101/img/2.jpg"
                },
                new PhoneVM 
                {
                    brand = "Xiaomi",
                    model = "mi8",
                    price = 7000,
                    color = ColorPhone.Black,
                    image = "http://192.168.56.101/img/3.jpg"
                },
            };
            return new OkObjectResult(list);
        }
    }
}
