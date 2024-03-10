using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SVC_Supplier.Models;

namespace SVC_Supplier.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index(string searchString)
        {
            List<ProductDb> productDbList;

            using (var context = new SvcSupplierContext())
            {
                IQueryable<ProductDb> products = context.Products;

                if (!String.IsNullOrEmpty(searchString))
                {
                    string searchLower = searchString.ToLower();
                    products = products.Where(s => s.Name.ToLower().Contains(searchLower) || s.Brand.ToLower().Contains(searchLower));
                }

                productDbList = products.ToList();
            }

            List<ProductModel> productModelList = productDbList.Select(p =>
            {
                return new ProductModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Brand = p.Brand,
                    Department = p.Department,
                    Description = p.Description,
                    Price = p.Price,
                    UnitsInLot = p.UnitsInLot,
                    ImagePath = p.ImagePath
                };
            }).ToList();

            ViewBag.SearchBar = searchString;

            return View(productModelList);
        }


        public IActionResult Product()
        {
            return View();
        }

        public IActionResult Message()
        {
            return View();
        }

        public IActionResult Orders()
        {
            return View();
        }

        public IActionResult OrderDetails()
        {
            return View();
        }

        public IActionResult Payment()
        {
            return View();
        }
    }
}
