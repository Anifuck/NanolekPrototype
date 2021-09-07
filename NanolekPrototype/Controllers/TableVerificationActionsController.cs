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
    public class TableVerificationActionsController : Controller
    {
        private readonly ApplicationContext _context;

        public TableVerificationActionsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: TableVerificationActions
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.VerificationActions.Include(t => t.FormCheckingRejectionOfDefectiveTablet).Include(t => t.TaskMaster);
            return View(await applicationContext.ToListAsync());
        }

        // GET: TableVerificationActions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableVerificationAction = await _context.VerificationActions
                .Include(t => t.FormCheckingRejectionOfDefectiveTablet)
                .Include(t => t.TaskMaster)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableVerificationAction == null)
            {
                return NotFound();
            }

            return View(tableVerificationAction);
        }

        // GET: TableVerificationActions/Create
        public IActionResult Create()
        {
            ViewData["FormCheckingRejectionOfDefectiveTabletId"] = new SelectList(_context.FormCheckingRejectionOfDefectiveTablets, "Id", "Id");
            ViewData["TaskMasterId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: TableVerificationActions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FormCheckingRejectionOfDefectiveTabletId,IsActive,Action,IsApproved,TaskMasterId")] TableVerificationAction tableVerificationAction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tableVerificationAction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FormCheckingRejectionOfDefectiveTabletId"] = new SelectList(_context.FormCheckingRejectionOfDefectiveTablets, "Id", "Id", tableVerificationAction.FormCheckingRejectionOfDefectiveTabletId);
            ViewData["TaskMasterId"] = new SelectList(_context.Users, "Id", "Id", tableVerificationAction.TaskMasterId);
            return View(tableVerificationAction);
        }

        // GET: TableVerificationActions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableVerificationAction = await _context.VerificationActions.FindAsync(id);
            if (tableVerificationAction == null)
            {
                return NotFound();
            }
            ViewData["FormCheckingRejectionOfDefectiveTabletId"] = new SelectList(_context.FormCheckingRejectionOfDefectiveTablets, "Id", "Id", tableVerificationAction.FormCheckingRejectionOfDefectiveTabletId);
            ViewData["TaskMasterId"] = new SelectList(_context.Users, "Id", "FullName", tableVerificationAction.TaskMasterId);
            return View(tableVerificationAction);
        }

        // POST: TableVerificationActions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TableVerificationAction tableVerificationAction)
        {
            if (id != tableVerificationAction.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tableVerificationAction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TableVerificationActionExists(tableVerificationAction.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "FormCheckingRejectionOfDefectiveTablets", new {id = tableVerificationAction.FormCheckingRejectionOfDefectiveTabletId});
            }
            ViewData["FormCheckingRejectionOfDefectiveTabletId"] = new SelectList(_context.FormCheckingRejectionOfDefectiveTablets, "Id", "Id", tableVerificationAction.FormCheckingRejectionOfDefectiveTabletId);
            ViewData["TaskMasterId"] = new SelectList(_context.Users, "Id", "Id", tableVerificationAction.TaskMasterId);
            return View(tableVerificationAction);
        }

        // GET: TableVerificationActions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableVerificationAction = await _context.VerificationActions
                .Include(t => t.FormCheckingRejectionOfDefectiveTablet)
                .Include(t => t.TaskMaster)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableVerificationAction == null)
            {
                return NotFound();
            }

            return View(tableVerificationAction);
        }

        // POST: TableVerificationActions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tableVerificationAction = await _context.VerificationActions.FindAsync(id);
            _context.VerificationActions.Remove(tableVerificationAction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TableVerificationActionExists(int id)
        {
            return _context.VerificationActions.Any(e => e.Id == id);
        }
    }
}
