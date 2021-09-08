using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NanolekPrototype.Context;
using NanolekPrototype.EntityModels.Models;

namespace NanolekPrototype.Controllers
{
    public class TablePackagingControlsController : Controller
    {
        private readonly ApplicationContext _context;

        public TablePackagingControlsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: TablePackagingControls
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.PackagingControls.Include(t => t.FormControlOfPrimaryPackaging).Include(t => t.TaskMaster);
            return View(await applicationContext.ToListAsync());
        }

        // GET: TablePackagingControls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tablePackagingControl = await _context.PackagingControls
                .Include(t => t.FormControlOfPrimaryPackaging)
                .Include(t => t.TaskMaster)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tablePackagingControl == null)
            {
                return NotFound();
            }

            return View(tablePackagingControl);
        }

        // GET: TablePackagingControls/Create
        public IActionResult Create(int formId)
        {
            ViewData["FormControlOfPrimaryPackagingId"] = formId;
            ViewData["TaskMasterId"] = new SelectList(_context.Users, "Id", "FullName");
            return View();
        }

        // POST: TablePackagingControls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TablePackagingControl tablePackagingControl)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tablePackagingControl);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "FormControlOfPrimaryPackagings", new {id = tablePackagingControl.FormControlOfPrimaryPackagingId});
            }
            ViewData["FormControlOfPrimaryPackagingId"] = new SelectList(_context.FormControlOfPrimaryPackagings, "Id", "Id", tablePackagingControl.FormControlOfPrimaryPackagingId);
            ViewData["TaskMasterId"] = new SelectList(_context.Users, "Id", "Id", tablePackagingControl.TaskMasterId);
            return View(tablePackagingControl);
        }

        // GET: TablePackagingControls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tablePackagingControl = await _context.PackagingControls.FindAsync(id);
            if (tablePackagingControl == null)
            {
                return NotFound();
            }
            ViewData["FormControlOfPrimaryPackagingId"] = new SelectList(_context.FormControlOfPrimaryPackagings, "Id", "Id", tablePackagingControl.FormControlOfPrimaryPackagingId);
            ViewData["TaskMasterId"] = new SelectList(_context.Users, "Id", "FullName", tablePackagingControl.TaskMasterId);
            return View(tablePackagingControl);
        }

        // POST: TablePackagingControls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TablePackagingControl tablePackagingControl)
        {
            if (id != tablePackagingControl.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tablePackagingControl);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TablePackagingControlExists(tablePackagingControl.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "FormControlOfPrimaryPackagings", new { id = tablePackagingControl.FormControlOfPrimaryPackagingId });
            }
            ViewData["FormControlOfPrimaryPackagingId"] = new SelectList(_context.FormControlOfPrimaryPackagings, "Id", "Id", tablePackagingControl.FormControlOfPrimaryPackagingId);
            ViewData["TaskMasterId"] = new SelectList(_context.Users, "Id", "FullName", tablePackagingControl.TaskMasterId);
            return View(tablePackagingControl);
        }

        // GET: TablePackagingControls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tablePackagingControl = await _context.PackagingControls
                .Include(t => t.FormControlOfPrimaryPackaging)
                .Include(t => t.TaskMaster)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tablePackagingControl == null)
            {
                return NotFound();
            }

            return View(tablePackagingControl);
        }

        // POST: TablePackagingControls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tablePackagingControl = await _context.PackagingControls.FindAsync(id);
            _context.PackagingControls.Remove(tablePackagingControl);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "FormControlOfPrimaryPackagings", new { id = tablePackagingControl.FormControlOfPrimaryPackagingId });
        }

        private bool TablePackagingControlExists(int id)
        {
            return _context.PackagingControls.Any(e => e.Id == id);
        }
    }
}
