using Microsoft.AspNetCore.Mvc;

namespace test1.Controllers
{
    public class EbookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
