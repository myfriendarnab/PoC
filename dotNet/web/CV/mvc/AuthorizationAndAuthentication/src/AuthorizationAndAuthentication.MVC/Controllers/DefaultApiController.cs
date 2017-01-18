using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthorizationAndAuthentication.MVC.Controllers
{
    [Produces("application/json")]
    [Route("api/DefaultApi")]
    public class DefaultApiController : Controller
    {
        [HttpGet]
        public IActionResult Get() => Ok("success");
    }
}