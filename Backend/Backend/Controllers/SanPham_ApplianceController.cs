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
    public class SanPham_ApplianceController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SanPham_ApplianceController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SanPham_Appliance
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SanPham_Appliance>>> GetsanPham_Appliances()
        {
            return await _context.sanPham_Appliances.ToListAsync();
        }

        // GET: api/SanPham_Appliance/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SanPham_Appliance>> GetSanPham_Appliance(string id)
        {
            var sanPham_Appliance = await _context.sanPham_Appliances.FindAsync(id);

            if (sanPham_Appliance == null)
            {
                return NotFound();
            }

            return sanPham_Appliance;
        }

        // PUT: api/SanPham_Appliance/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSanPham_Appliance(string id, SanPham_Appliance sanPham_Appliance)
        {
            if (id != sanPham_Appliance.Loai)
            {
                return BadRequest();
            }

            _context.Entry(sanPham_Appliance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SanPham_ApplianceExists(id))
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

        // POST: api/SanPham_Appliance
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<SanPham_Appliance>> PostSanPham_Appliance(SanPham_Appliance sanPham_Appliance)
        {
            _context.sanPham_Appliances.Add(sanPham_Appliance);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSanPham_Appliance", new { id = sanPham_Appliance.Loai }, sanPham_Appliance);
        }

        // DELETE: api/SanPham_Appliance/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SanPham_Appliance>> DeleteSanPham_Appliance(string id)
        {
            var sanPham_Appliance = await _context.sanPham_Appliances.FindAsync(id);
            if (sanPham_Appliance == null)
            {
                return NotFound();
            }

            _context.sanPham_Appliances.Remove(sanPham_Appliance);
            await _context.SaveChangesAsync();

            return sanPham_Appliance;
        }

        private bool SanPham_ApplianceExists(string id)
        {
            return _context.sanPham_Appliances.Any(e => e.Loai == id);
        }
    }
}
