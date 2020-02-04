using Microsoft.AspNetCore.Mvc;

namespace FlowDemo.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DemoController : Controller
    {

        [HttpGet("demo1")]
        public IActionResult GetDemo1()
        {
            return Json(new {demo = 1, demo1 = 2});
        }
    }
}