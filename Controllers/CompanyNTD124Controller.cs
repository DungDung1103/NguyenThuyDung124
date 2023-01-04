using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenThuyDung124.Models;

namespace NguyenThuyDung124.Controllers
{
    public class CompanyNTD124Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public CompanyNTD124Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CompanyNTD124
        public async Task<IActionResult> Index()
        {
              return _context.CompanyNTD124 != null ? 
                          View(await _context.CompanyNTD124.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.CompanyNTD124'  is null.");
        }

        // GET: CompanyNTD124/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.CompanyNTD124 == null)
            {
                return NotFound();
            }

            var companyNTD124 = await _context.CompanyNTD124
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyNTD124 == null)
            {
                return NotFound();
            }

            return View(companyNTD124);
        }

        // GET: CompanyNTD124/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyNTD124/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] CompanyNTD124 companyNTD124)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyNTD124);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyNTD124);
        }

        // GET: CompanyNTD124/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.CompanyNTD124 == null)
            {
                return NotFound();
            }

            var companyNTD124 = await _context.CompanyNTD124.FindAsync(id);
            if (companyNTD124 == null)
            {
                return NotFound();
            }
            return View(companyNTD124);
        }

        // POST: CompanyNTD124/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyId,CompanyName")] CompanyNTD124 companyNTD124)
        {
            if (id != companyNTD124.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyNTD124);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyNTD124Exists(companyNTD124.CompanyId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(companyNTD124);
        }

        // GET: CompanyNTD124/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.CompanyNTD124 == null)
            {
                return NotFound();
            }

            var companyNTD124 = await _context.CompanyNTD124
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyNTD124 == null)
            {
                return NotFound();
            }

            return View(companyNTD124);
        }

        // POST: CompanyNTD124/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.CompanyNTD124 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CompanyNTD124'  is null.");
            }
            var companyNTD124 = await _context.CompanyNTD124.FindAsync(id);
            if (companyNTD124 != null)
            {
                _context.CompanyNTD124.Remove(companyNTD124);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyNTD124Exists(string id)
        {
          return (_context.CompanyNTD124?.Any(e => e.CompanyId == id)).GetValueOrDefault();
        }
    }
}
