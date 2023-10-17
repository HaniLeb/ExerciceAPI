using Microsoft.AspNetCore.Mvc;

namespace ExerciceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Get()
        {
            const string html = "<body><h1>Hello, World</h1></body>";
            return Content(html, "text/html");
        }
    }
}