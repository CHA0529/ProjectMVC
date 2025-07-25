using Microsoft.AspNetCore.Mvc;

namespace test1.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
