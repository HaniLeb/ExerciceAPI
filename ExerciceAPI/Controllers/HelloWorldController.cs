using Microsoft.AspNetCore.Mvc;

namespace ExerciceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            const string html = "<script src='https://cdn.tailwindcss.com'></script><html class='bg-white dark:bg-gray-900'><body><section class='bg-white dark:bg-gray-900'><div class='py-8 px-4 mx-auto max-w-screen-xl text-center lg:py-16'><h1 class='mb-4 text-4xl font-extrabold tracking-tight leading-none text-gray-900 md:text-5xl lg:text-6xl dark:text-white'>Hello World!</h1></div></div></section></body></html>";
            return Content(html, "text/html");
        }
    }
}
