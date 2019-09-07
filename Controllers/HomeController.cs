using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Etudiant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            //  return new ObjectResult("Works");
            var message = "<h5 style='font-family: Arial, Helvetica, sans-serif;padding:5px;color:white;background-color:#03A678;'>Server is up!</h5>";
            return new ContentResult()
            {
                Content = message,
                ContentType = "text/html"
            };

        }

        // Production error handling
        [HttpGet("error")]
        public IActionResult Error()
        {
            return new ObjectResult("error, please review server log for more information.");
        }
    }
}