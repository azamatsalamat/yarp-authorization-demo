using Microsoft.AspNetCore.Mvc;

namespace YarpDemo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MainController : Controller
    {
        [HttpGet("test")]
        public string Test()
        {
            var user = User;
            return "hello world";
        }
    }
}
