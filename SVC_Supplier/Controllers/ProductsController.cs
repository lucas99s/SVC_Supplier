using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
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


        public IActionResult Product(int productId)
        {
            ProductDb productDb;

            using (var context = new SvcSupplierContext())
            {
                productDb = context.Products.FirstOrDefault(p => p.Id == productId);
            }

            ProductModel productModel = new ProductModel()
            {
                Id = productDb.Id,
                Name = productDb.Name,
                Brand = productDb.Brand,
                Department = productDb.Department,
                Description = productDb.Description,
                Price = productDb.Price,
                UnitsInLot = productDb.UnitsInLot,
                ImagePath = productDb.ImagePath
            };

            return View(productModel);
        }



        public IActionResult Message()
        {
            return View();
        }

        public IActionResult Orders()
        {
            List<OrderDb> orderDbList;
            List<ProductDb> productDbList;

            using (var context = new SvcSupplierContext())
            {
                IQueryable<OrderDb> orders = context.Orders;
                orderDbList = orders.ToList();

                var productIds = orderDbList.Select(o => o.ProductId).Distinct();

                productDbList = context.Products.Where(p => productIds.Contains(p.Id)).ToList();
            }

            // Mapear para os modelos
            List<OrderModel> orderModelList = orderDbList.Select(o =>
            {
                var productDb = productDbList.First(p => p.Id == o.ProductId);

                return new OrderModel()
                {
                    Id = o.Id,
                    ProductId = o.ProductId,
                    Status = o.Status,
                    Quantity = o.Quantity,
                    Product = new ProductModel()
                    {
                        Id = productDb.Id,
                        Name = productDb.Name,
                        Brand = productDb.Brand,
                        Department = productDb.Department,
                        Description = productDb.Description,
                        Price = productDb.Price * o.Quantity,
                        UnitsInLot = productDb.UnitsInLot,
                        ImagePath = productDb.ImagePath
                    }
                };
            }).ToList();

            return View(orderModelList);
        }


        public IActionResult OrderDetails(int productId, int quantity)
        {
            ProductDb productDb;

            using (var context = new SvcSupplierContext())
            {
                productDb = context.Products.FirstOrDefault(p => p.Id == productId);
            }

            ProductModel productModel = new ProductModel()
            {
                Id = productDb.Id,
                Name = productDb.Name,
                Brand = productDb.Brand,
                Department = productDb.Department,
                Description = productDb.Description,
                Price = productDb.Price * quantity,
                UnitsInLot = productDb.UnitsInLot,
                ImagePath = productDb.ImagePath,
                Quantity = quantity
            };

            return View(productModel);
        }

        public IActionResult Payment(int productId, int quantity)
        { 
            ProductDb productDb;

            using (var context = new SvcSupplierContext())
            {
                productDb = context.Products.FirstOrDefault(p => p.Id == productId);
            }

            ProductModel productModel = new ProductModel()
            {
                Id = productDb.Id,
                Name = productDb.Name,
                Brand = productDb.Brand,
                Department = productDb.Department,
                Description = productDb.Description,
                Price = productDb.Price * quantity,
                UnitsInLot = productDb.UnitsInLot,
                ImagePath = productDb.ImagePath,
                Quantity = quantity
            };

            return View(productModel);
        }
        public IActionResult DataPaymentForm(OrderModel order)
        {
            using (var db = new SvcSupplierContext())
            {

                var newOrder = new OrderDb
                {
                    ProductId = order.ProductId,
                    Status = "sa",
                    Quantity = order.Quantity
                };

                db.Add(newOrder);
                db.SaveChanges();

            }
            return View(order);
        }

        public IActionResult BuyItems(
            string address,
            int number,
            string zipCode,
            string cardNumber,
            string nameOnCard,
            string validDate,
            int code
        )
        {
            return RedirectToAction("Index");
        }

        public IActionResult PaymentConfirmation()
        {
            return View();
        }
    }
}
