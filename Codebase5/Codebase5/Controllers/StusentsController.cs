using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Codebase5.Data;
using Codebase5.Models;

namespace Codebase5.Controllers
{
    public class StusentsController : Controller
    {
        private readonly Codebase5Context _context;

        public StusentsController(Codebase5Context context)
        {
            _context = context;
        }

        // GET: Stusents
        public async Task<IActionResult> Index()
        {
            return View(await _context.Stusent.ToListAsync());
        }

        // GET: Stusents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stusent = await _context.Stusent
                .FirstOrDefaultAsync(m => m.ID == id);
            if (stusent == null)
            {
                return NotFound();
            }

            return View(stusent);
        }

        // GET: Stusents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stusents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,Location")] Stusent stusent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stusent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stusent);
        }

        // GET: Stusents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stusent = await _context.Stusent.FindAsync(id);
            if (stusent == null)
            {
                return NotFound();
            }
            return View(stusent);
        }

        // POST: Stusents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirstName,LastName,Location")] Stusent stusent)
        {
            if (id != stusent.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stusent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StusentExists(stusent.ID))
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
            return View(stusent);
        }

        // GET: Stusents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stusent = await _context.Stusent
                .FirstOrDefaultAsync(m => m.ID == id);
            if (stusent == null)
            {
                return NotFound();
            }

            return View(stusent);
        }

        // POST: Stusents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stusent = await _context.Stusent.FindAsync(id);
            _context.Stusent.Remove(stusent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StusentExists(int id)
        {
            return _context.Stusent.Any(e => e.ID == id);
        }
    }
}
