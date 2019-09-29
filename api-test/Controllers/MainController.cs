using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using api_test.Models;
using api_test.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace api_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly DAO _db;
        public MainController(DAO db) {
            _db = db;
        }
        // GET api/main
        [HttpGet]
        public ActionResult<Main> Get()
        {
            //t();
            return _db.GetMain();
        }
        [HttpPost("filter")]
        public ActionResult<Main> Get([FromBody]List<int> filterIds)
        {
            return new Main()
            {
                Categories = new List<Category>() { },//Category.MockCategories,
                Points = Point.MockPoints,
            };
        }
    }
}