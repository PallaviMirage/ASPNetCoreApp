using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Pallavi", "Irshad", "Bhavana", "Madhura", "Nitish" };
          
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"You are passing Id is - {id}";
        }
    }
}
