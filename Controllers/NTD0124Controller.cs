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
    public class NTD0124Controller : Controller
    {
        private readonly ApplicationDbContext _context;

        public NTD0124Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: NTD0124
        public async Task<IActionResult> Index()
        {
              return _context.NTD0124 != null ? 
                          View(await _context.NTD0124.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.NTD0124'  is null.");
        }

        // GET: NTD0124/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.NTD0124 == null)
            {
                return NotFound();
            }

            var nTD0124 = await _context.NTD0124
                .FirstOrDefaultAsync(m => m.NTDId == id);
            if (nTD0124 == null)
            {
                return NotFound();
            }

            return View(nTD0124);
        }

        // GET: NTD0124/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NTD0124/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NTDId,NTDName,NTDGender")] NTD0124 nTD0124)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nTD0124);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nTD0124);
        }

        // GET: NTD0124/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.NTD0124 == null)
            {
                return NotFound();
            }

            var nTD0124 = await _context.NTD0124.FindAsync(id);
            if (nTD0124 == null)
            {
                return NotFound();
            }
            return View(nTD0124);
        }

        // POST: NTD0124/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("NTDId,NTDName,NTDGender")] NTD0124 nTD0124)
        {
            if (id != nTD0124.NTDId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nTD0124);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTD0124Exists(nTD0124.NTDId))
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
            return View(nTD0124);
        }

        // GET: NTD0124/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.NTD0124 == null)
            {
                return NotFound();
            }

            var nTD0124 = await _context.NTD0124
                .FirstOrDefaultAsync(m => m.NTDId == id);
            if (nTD0124 == null)
            {
                return NotFound();
            }

            return View(nTD0124);
        }

        // POST: NTD0124/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.NTD0124 == null)
            {
                return Problem("Entity set 'ApplicationDbContext.NTD0124'  is null.");
            }
            var nTD0124 = await _context.NTD0124.FindAsync(id);
            if (nTD0124 != null)
            {
                _context.NTD0124.Remove(nTD0124);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTD0124Exists(string id)
        {
          return (_context.NTD0124?.Any(e => e.NTDId == id)).GetValueOrDefault();
        }
    }
}
