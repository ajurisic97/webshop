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
    public class KategorijaApiController : ControllerBase
    {
        private readonly WebShopAndeloContext _context;

        public KategorijaApiController(WebShopAndeloContext context)
        {
            _context = context;
        }

        // GET: api/KategorijaApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kategorija>>> GetKategorija()
        {
            return await _context.Kategorija.ToListAsync();
        }

        // GET: api/KategorijaApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Kategorija>> GetKategorija(int id)
        {
            var kategorija = await _context.Kategorija.FindAsync(id);

            if (kategorija == null)
            {
                return NotFound();
            }

            return kategorija;
        }

        // PUT: api/KategorijaApi/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKategorija(int id, Kategorija kategorija)
        {
            if (id != kategorija.Idkategorija)
            {
                return BadRequest();
            }

            _context.Entry(kategorija).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KategorijaExists(id))
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

        // POST: api/KategorijaApi
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Kategorija>> PostKategorija(Kategorija kategorija)
        {
            _context.Kategorija.Add(kategorija);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKategorija", new { id = kategorija.Idkategorija }, kategorija);
        }

        // DELETE: api/KategorijaApi/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Kategorija>> DeleteKategorija(int id)
        {
            var kategorija = await _context.Kategorija.FindAsync(id);
            if (kategorija == null)
            {
                return NotFound();
            }

            _context.Kategorija.Remove(kategorija);
            await _context.SaveChangesAsync();

            return kategorija;
        }

        private bool KategorijaExists(int id)
        {
            return _context.Kategorija.Any(e => e.Idkategorija == id);
        }
    }
}
