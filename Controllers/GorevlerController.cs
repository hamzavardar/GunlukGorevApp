using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GunlukGorevApp.Data;
using GunlukGorevApp.Models;

namespace GunlukGorevApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GorevlerController : ControllerBase
    {
        private readonly UygulamaDbContext _context;

        public GorevlerController(UygulamaDbContext context)
        {
            _context = context;
        }

        //get
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gorev>>> HepsiniGetir()
        {
            return await _context.Gorevler.ToListAsync();
        }

        //post
        [HttpPost]
        public async Task<ActionResult<Gorev>> YeniEkle([FromBody] Gorev yeniGorev)
        {
            yeniGorev.OlusturmaTarihi = DateTime.Now;
            _context.Gorevler.Add(yeniGorev);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(HepsiniGetir), new { id = yeniGorev.Id }, yeniGorev);
        }

        //put
        [HttpPut("{id}")]
        public async Task<IActionResult> DurumDegistir(int id)
        {
            var gorev = await _context.Gorevler.FindAsync(id);
            if (gorev == null)
            {
                return NotFound("Görev bulunamadı!");
            }

            gorev.TamamlandiMi = !gorev.TamamlandiMi;
            await _context.SaveChangesAsync();
            return Ok(gorev);
        }

        //delete
        [HttpDelete("{id}")]
        public async Task<IActionResult> Sil(int id)
        {
            var gorev = await _context.Gorevler.FindAsync(id);
            if (gorev == null)
            {
                return NotFound("Silinecek görev bulunamadı!");
            }

            _context.Gorevler.Remove(gorev);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}