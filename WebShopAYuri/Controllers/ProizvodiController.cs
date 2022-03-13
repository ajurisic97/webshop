using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShopAYuri.DbModels;
using static WebShopAYuri.Startup;
namespace WebShopAYuri.Controllers
{
    public class ProizvodiController : Controller
    {
        private readonly WebShopAndeloContext _dbContext;

        public ProizvodiController(WebShopAndeloContext dbContext)
        {
            _dbContext = dbContext;
        }

        [sessionAdminTimeout]
        public IActionResult SviProizvodi()
        {
            var userA = HttpContext.Session.GetString("sessionAdmin");
            ViewBag.user = userA;
            var rez = _dbContext.Proizvod.ToList();
            return View(rez);
        }

        public IActionResult OdabraniProizvod(string p)
        {
            var rez = _dbContext.Proizvod.ToList().Find(odabran=>odabran.Naziv.ToString()==p);
            return View(rez);
        }
    }
}