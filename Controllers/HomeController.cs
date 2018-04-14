using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/")]
    public class HomeController : Controller
    {
        // GET api/
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "version:001", "status:ok" };
        }
    }
}