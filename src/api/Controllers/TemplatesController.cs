using System;
using Microsoft.AspNetCore.Mvc;
using SendGrid;
namespace api.Controllers
{
    [Route("api/[controller]")]
    public class TemplatesController : Controller
    {
        public IActionResult Get()
        {
            return Ok();
        }
    }
}