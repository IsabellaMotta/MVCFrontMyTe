using Microsoft.AspNetCore.Mvc;

namespace MyTe.Controllers

{
    public class UserPerfilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
