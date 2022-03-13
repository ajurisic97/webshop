using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebShopAYuri.DbModels;
using WebShopAYuri.Models;

namespace WebShopAYuri.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly WebShopAndeloContext _dbContext;
        public HomeController(ILogger<HomeController> logger,WebShopAndeloContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var rez = _dbContext.Proizvod.ToList();
            return View(rez);
       }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Mobiteli()
        {
            var rez = _dbContext.Proizvod.ToList().Where(x=>x.KategorijaId==1);
            return View(rez);
        }

        public IActionResult Tableti()
        {
            var rez = _dbContext.Proizvod.ToList().Where(x => x.KategorijaId == 2);
            return View(rez);
        }

        public IActionResult Satovi()
        {
            var rez = _dbContext.Proizvod.ToList().Where(x => x.KategorijaId == 3);
            return View(rez);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
