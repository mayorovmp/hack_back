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
    public class BlogController : ControllerBase
    {
        //get api/blog
        [HttpGet]
        public ActionResult<Tape> Get()
        {
            return Tape.MockTape;
        }

        //get api/blog
        [HttpGet("{postId}")]
        public ActionResult<PostDetail> GetDetail(int postId)
        {
            return PostDetail.MockPostDetail;
        }
    }
}