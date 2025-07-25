using Microsoft.AspNetCore.Mvc;

namespace test1.Controllers
{
    public class ForumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
