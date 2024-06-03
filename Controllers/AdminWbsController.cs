using Microsoft.AspNetCore.Mvc;

namespace MyTe.Controllers
{
    public class AdminWbsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }

    }
}
