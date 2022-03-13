using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebShopAYuri.DbModels;

namespace WebShopAYuri.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProizvodApiController : ControllerBase
    {
        private readonly WebShopAndeloContext _context;

        public ProizvodApiController(WebShopAndeloContext context)
        {
            _context = context;
        }

        // GET: api/ProizvodApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proizvod>>> GetProizvod()
        {
            return await _context.Proizvod.ToListAsync();
        }

        // GET: api/ProizvodApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Proizvod>> GetProizvod(int id)
        {
            var proizvod = await _context.Proizvod.FindAsync(id);

            if (proizvod == null)
            {
                return NotFound();
            }

            return proizvod;
        }

        // PUT: api/ProizvodApi/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProizvod(int id, Proizvod proizvod)
        {
            if (id != proizvod.Idproizvod)
            {
                return BadRequest();
            }

            _context.Entry(proizvod).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProizvodExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ProizvodApi
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Proizvod>> PostProizvod(Proizvod proizvod)
        {
            _context.Proizvod.Add(proizvod);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProizvod", new { id = proizvod.Idproizvod }, proizvod);
        }

        // DELETE: api/ProizvodApi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Proizvod>> DeleteProizvod(int id)
        {
            var proizvod = await _context.Proizvod.FindAsync(id);
            if (proizvod == null)
            {
                return NotFound();
            }

            _context.Proizvod.Remove(proizvod);
            await _context.SaveChangesAsync();

            return proizvod;
        }

        private bool ProizvodExists(int id)
        {
            return _context.Proizvod.Any(e => e.Idproizvod == id);
        }
    }
}
