using Microsoft.AspNetCore.Mvc;

namespace SVC_Supplier.Controllers
{
    public class SellController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
