using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookingapi.Controllers
{
    [Route("events")]
    [ApiController]
    public class PostEventController : ControllerBase
    {
        public PostEventController()
        {

        }
        [HttpGet]
        public string Get()
        {
            return "tjolahoppsansa";
        }

        [HttpPost]
        public string Post( string @event)
        {
            return @event;
        }
    }
}
