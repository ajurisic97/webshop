using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShopAYuri.Models;
using WebShopAYuri.Services;

namespace WebShopAYuri.Controllers
{
    [Route("api/proizvodi")]
    [ApiController]
    public class ProizvodiApiController : ControllerBase
    {

        private ProizvodiService _proizvodiService;
        public ProizvodiApiController(ProizvodiService ps)
        {
            _proizvodiService = ps;
        }

        [HttpGet]
        public ActionResult<List<Proizvod>> Get()
        {
            return _proizvodiService.GetAll().ToList();
        }

        // /api/proizvodi/0 -> vraća samo onog čiji je ID=0
        [HttpGet("{id}")]
        public ActionResult<Proizvod> Get(int id)
        {
            return Ok();
        }
    }
}