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
    public class SanPham_DienThoaiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SanPham_DienThoaiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SanPham_DienThoai
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SanPham_DienThoai>>> GetsanPham_DienThoais()
        {
            return await _context.sanPham_DienThoais.ToListAsync();
        }

        // GET: api/SanPham_DienThoai/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SanPham_DienThoai>> GetSanPham_DienThoai(int id)
        {
            var sanPham_DienThoai = await _context.sanPham_DienThoais.FindAsync(id);

            if (sanPham_DienThoai == null)
            {
                return NotFound();
            }

            return sanPham_DienThoai;
        }

        // PUT: api/SanPham_DienThoai/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSanPham_DienThoai(int id, SanPham_DienThoai sanPham_DienThoai)
        {
            if (id != sanPham_DienThoai.MaDT)
            {
                return BadRequest();
            }

            _context.Entry(sanPham_DienThoai).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SanPham_DienThoaiExists(id))
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

        // POST: api/SanPham_DienThoai
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<SanPham_DienThoai>> PostSanPham_DienThoai(SanPham_DienThoai sanPham_DienThoai)
        {
            _context.sanPham_DienThoais.Add(sanPham_DienThoai);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSanPham_DienThoai", new { id = sanPham_DienThoai.MaDT }, sanPham_DienThoai);
        }

        // DELETE: api/SanPham_DienThoai/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SanPham_DienThoai>> DeleteSanPham_DienThoai(int id)
        {
            var sanPham_DienThoai = await _context.sanPham_DienThoais.FindAsync(id);
            if (sanPham_DienThoai == null)
            {
                return NotFound();
            }

            _context.sanPham_DienThoais.Remove(sanPham_DienThoai);
            await _context.SaveChangesAsync();

            return sanPham_DienThoai;
        }

        private bool SanPham_DienThoaiExists(int id)
        {
            return _context.sanPham_DienThoais.Any(e => e.MaDT == id);
        }
    }
}
