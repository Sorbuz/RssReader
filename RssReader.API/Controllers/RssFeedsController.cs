using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace RssReader.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RssFeedsController
    {
         // GET api/rssfeeds
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value12", "value2" };
        }

        // GET api/rssfeeds/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}