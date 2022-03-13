using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using static WebShopAYuri.Startup;
namespace WebShopAYuri.Controllers
{
    public class LogController : Controller
    {
        public IActionResult LogInAdmin()
        {
            return View();
        }


        [HttpPost]
        public IActionResult LogInAdmin(string username, string password)
        {
            HttpContext.Session.SetString("adminSession", "adminSession");
            
            if (username == "admin" && password == "admin")
            {

                return RedirectToRoute(new { controller = "Proizvodi", action = "SviProizvodi" });
                
            }
            else
            {
                return View();
            }

        }
    }
}
