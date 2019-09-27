using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_test.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        // GET api/main
        [HttpGet]
        public ActionResult<Main> Get()
        {
            return new Main()
            {
                Categories = Category.MockCategories,
                Points = Point.MockPoints,
            };
        }
    }
}