using Microsoft.AspNetCore.Mvc;

namespace SVC_Supplier.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
