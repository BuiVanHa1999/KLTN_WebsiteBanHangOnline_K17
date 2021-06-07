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
    public class DanhGiasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DanhGiasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/DanhGias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DanhGia>>> GetdanhGias()
        {
            return await _context.danhGias.ToListAsync();
        }

        // GET: api/DanhGias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DanhGia>> GetDanhGia(int id)
        {
            var danhGia = await _context.danhGias.FindAsync(id);

            if (danhGia == null)
            {
                return NotFound();
            }

            return danhGia;
        }

        // PUT: api/DanhGias/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDanhGia(int id, DanhGia danhGia)
        {
            if (id != danhGia.MaDanhGia)
            {
                return BadRequest();
            }

            _context.Entry(danhGia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DanhGiaExists(id))
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

        // POST: api/DanhGias
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<DanhGia>> PostDanhGia(DanhGia danhGia)
        {
            _context.danhGias.Add(danhGia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDanhGia", new { id = danhGia.MaDanhGia }, danhGia);
        }

        // DELETE: api/DanhGias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DanhGia>> DeleteDanhGia(int id)
        {
            var danhGia = await _context.danhGias.FindAsync(id);
            if (danhGia == null)
            {
                return NotFound();
            }

            _context.danhGias.Remove(danhGia);
            await _context.SaveChangesAsync();

            return danhGia;
        }

        private bool DanhGiaExists(int id)
        {
            return _context.danhGias.Any(e => e.MaDanhGia == id);
        }
    }
}
