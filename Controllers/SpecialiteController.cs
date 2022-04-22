#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CtrlUpEmploye.DAL;
using CtrlUpEmploye.Models;

namespace CtrlUpEmploye.Controllers
{
    public class SpecialiteController : Controller
    {
        private readonly CtrlUpContext _context;

        public SpecialiteController(CtrlUpContext context)
        {
            _context = context;
        }



        // GET: Specialite
        public async Task<IActionResult> Index()
        {
            return View(await _context.Specialites.ToListAsync());
        }

        // GET: Specialite/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialite = await _context.Specialites
                .FirstOrDefaultAsync(m => m.SpecialiteID == id);
            if (specialite == null)
            {
                return NotFound();
            }

            return View(specialite);
        }

        // GET: Specialite/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Specialite/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SpecialiteID,Title")] Specialite specialite)
        {
            if (ModelState.IsValid)
            {
                _context.Add(specialite);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(specialite);
        }

        // GET: Specialite/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialite = await _context.Specialites.FindAsync(id);
            if (specialite == null)
            {
                return NotFound();
            }
            return View(specialite);
        }

        // POST: Specialite/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SpecialiteID,Title")] Specialite specialite)
        {
            if (id != specialite.SpecialiteID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(specialite);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpecialiteExists(specialite.SpecialiteID))
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
            return View(specialite);
        }

        // GET: Specialite/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialite = await _context.Specialites
                .FirstOrDefaultAsync(m => m.SpecialiteID == id);
            if (specialite == null)
            {
                return NotFound();
            }

            return View(specialite);
        }

        // POST: Specialite/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var specialite = await _context.Specialites.FindAsync(id);
            _context.Specialites.Remove(specialite);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpecialiteExists(int id)
        {
            return _context.Specialites.Any(e => e.SpecialiteID == id);
        }
    }
}
