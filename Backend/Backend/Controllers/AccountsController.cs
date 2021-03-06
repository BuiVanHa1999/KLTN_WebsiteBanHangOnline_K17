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
    public class AccountsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AccountsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Accounts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> GetAccounts()
        {
            return await _context.Accounts.ToListAsync();
        }

        // GET: api/Accounts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Account>> GetAccount(int id)
        {
            var account = await _context.Accounts.FindAsync(id);

            if (account == null)
            {
                return NotFound();
            }

            return account;
        }

        [HttpGet]
        [Route("Khach")]
        public async Task<ActionResult<IEnumerable<Account>>> GetSanPhamKhach()
        {
            var account = await _context.Accounts.Where(i => i.Role == "Khách").ToListAsync();
            return account;
        }

        [HttpGet]
        [Route("Admin")]
        public async Task<ActionResult<IEnumerable<Account>>> GetSanPhamAdmin()
        {
            var account = await _context.Accounts.Where(i => i.Role == "Admin").ToListAsync();
            return account;
        }

        [HttpGet]
        [Route("Shipper")]
        public async Task<ActionResult<IEnumerable<Account>>> GetSanPhamShipper()
        {
            var account = await _context.Accounts.Where(i => i.Role == "Shipper").ToListAsync();
            return account;
        }

        // PUT: api/Accounts/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccount(int id, Account account)
        {
            if (id != account.AccountID)
            {
                return BadRequest();
            }

            _context.Entry(account).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountExists(id))
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

        // POST: api/Accounts
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Account>> PostAccount(Account account)
        {
            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAccount", new { id = account.AccountID }, account);
        }

        // DELETE: api/Accounts/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Account>> DeleteAccount(int id)
        {
            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }

            _context.Accounts.Remove(account);
            await _context.SaveChangesAsync();

            return account;
        }

        private bool AccountExists(int id)
        {
            return _context.Accounts.Any(e => e.AccountID == id);
        }

        //POST: api/Accounts/Signin
        [HttpPost]
        [Route("Signin")]
        public async Task<ActionResult<Account>> signIn(Account account)
        {
            var accountdb = await _context.Accounts.ToListAsync();

            foreach (Account a in accountdb)
            {
                if (a.Email == account.Email && a.Password == account.Password)
                {
                    string email = a.Email;
                    var accountfind = _context.Accounts.Where(b => b.Email == email).FirstOrDefault();
                    return CreatedAtAction("GetAccount", new { id = accountfind.AccountID }, accountfind);
                }
            }
            return Content("Failse");
        }
    }
}
