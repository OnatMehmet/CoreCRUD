using Microsoft.AspNetCore.Mvc;

namespace CoreCRUD.Controllers
{
    public class Account : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
