using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SVC_Supplier.Models;
using Microsoft.AspNetCore.Http;

namespace SVC_Supplier.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            #pragma warning disable CS8605 // Unboxing a possibly null value.
            bool newRegistration = TempData.ContainsKey("NewRegistration") && (bool)TempData["NewRegistration"];

            if (newRegistration)
            {
                ViewBag.NewRegistration = "Usuário cadastrado com sucesso!";
            }

            TempData.Remove("NewRegistration");
            return View("Login");
        }

        public IActionResult SignIn()
        {
            return View("SignIn");
        }

        [HttpPost]
        public IActionResult SignIn(UserModel user)
        {
            using (var db = new SvcSupplierContext())
            {
                var existingUser = db.Users.FirstOrDefault(u => u.Email == user.Email);
                if (existingUser == null)
                {
                    if (user.Password.Length >= 8)
                    {
                        if (user.Password == user.PasswordConfirmation)
                        {

                            var newUser = new UserDb
                            {
                                Name = user.Name,
                                SurName = user.SurName,
                                Email = user.Email,
                                Password = user.Password
                            };

                            db.Add(newUser);
                            db.SaveChanges();

                            TempData["NewRegistration"] = true;
                            return RedirectToAction("Login", "Account");
                        }
                        else
                        {
                            ViewBag.PasswordMessage = "Senhas não são iguais!";
                        }
                    }
                    else
                    {
                        ViewBag.PasswordMessage = "Senha deve ter no mínimo 8 dígitos!";
                    }
                }
                else
                {
                    ViewBag.UserMessage = "E-mail já cadastrado!";
                }

            }

            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            using (var db = new SvcSupplierContext())
            {
                var existingUser = db.Users.FirstOrDefault(u => u.Email == user.Email);

                if (existingUser != null)
                {
                    if (existingUser.Password == user.Password)
                    {
                        HttpContext.Session.SetString("UserName", existingUser.Name);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.PasswordMessage = "Senha inválida!";
                    }

                }
                else
                {
                    ViewBag.EmailMessage = "Usuário inválido!";
                }
            }
            return View();
        }

    }
}
