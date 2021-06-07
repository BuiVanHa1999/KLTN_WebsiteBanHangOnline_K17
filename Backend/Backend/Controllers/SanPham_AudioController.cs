using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.Model;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SanPham_AudioController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SanPham_AudioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SanPham_Audio
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SanPham_Audio>>> GetsanPham_Audios()
        {
            return await _context.sanPham_Audios.ToListAsync();
        }

        // GET: api/SanPham_Audio/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SanPham_Audio>> GetSanPham_Audio(string id)
        {
            var sanPham_Audio = await _context.sanPham_Audios.FindAsync(id);

            if (sanPham_Audio == null)
            {
                return NotFound();
            }

            return sanPham_Audio;
        }

        // PUT: api/SanPham_Audio/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSanPham_Audio(string id, SanPham_Audio sanPham_Audio)
        {
            if (id != sanPham_Audio.TuongThich)
            {
                return BadRequest();
            }

            _context.Entry(sanPham_Audio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SanPham_AudioExists(id))
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

        // POST: api/SanPham_Audio
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<SanPham_Audio>> PostSanPham_Audio(SanPham_Audio sanPham_Audio)
        {
            _context.sanPham_Audios.Add(sanPham_Audio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSanPham_Audio", new { id = sanPham_Audio.TuongThich }, sanPham_Audio);
        }

        // DELETE: api/SanPham_Audio/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SanPham_Audio>> DeleteSanPham_Audio(string id)
        {
            var sanPham_Audio = await _context.sanPham_Audios.FindAsync(id);
            if (sanPham_Audio == null)
            {
                return NotFound();
            }

            _context.sanPham_Audios.Remove(sanPham_Audio);
            await _context.SaveChangesAsync();

            return sanPham_Audio;
        }

        private bool SanPham_AudioExists(string id)
        {
            return _context.sanPham_Audios.Any(e => e.TuongThich == id);
        }
    }
}
