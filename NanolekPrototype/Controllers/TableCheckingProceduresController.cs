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
    public class TableCheckingProceduresController : Controller
    {
        private readonly ApplicationContext _context;

        public TableCheckingProceduresController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: TableCheckingProcedures
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.CheckingProcedures.Include(t => t.Executor).Include(t => t.FormCheckingCheckweighingSetting);
            return View(await applicationContext.ToListAsync());
        }

        // GET: TableCheckingProcedures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableCheckingProcedure = await _context.CheckingProcedures
                .Include(t => t.Executor)
                .Include(t => t.FormCheckingCheckweighingSetting)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableCheckingProcedure == null)
            {
                return NotFound();
            }

            return View(tableCheckingProcedure);
        }

        // GET: TableCheckingProcedures/Create
        public IActionResult Create(int formId)
        {
            ViewData["ExecutorId"] = new SelectList(_context.Users, "Id", "FullName");
            ViewData["FormCheckingCheckweighingSettingId"] = formId;
            return View();
        }

        // POST: TableCheckingProcedures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TableCheckingProcedure tableCheckingProcedure)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tableCheckingProcedure);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "FormCheckingCheckweighingSettings", new {id = tableCheckingProcedure.FormCheckingCheckweighingSettingId});
            }
            ViewData["ExecutorId"] = new SelectList(_context.Users, "Id", "FullName", tableCheckingProcedure.ExecutorId);
            ViewData["FormCheckingCheckweighingSettingId"] = new SelectList(_context.FormCheckingCheckweighingSettings, "Id", "Id", tableCheckingProcedure.FormCheckingCheckweighingSettingId);
            return View(tableCheckingProcedure);
        }

        // GET: TableCheckingProcedures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableCheckingProcedure = await _context.CheckingProcedures.FindAsync(id);
            if (tableCheckingProcedure == null)
            {
                return NotFound();
            }
            ViewData["ExecutorId"] = new SelectList(_context.Users, "Id", "FullName", tableCheckingProcedure.ExecutorId);
            ViewData["FormCheckingCheckweighingSettingId"] = tableCheckingProcedure.FormCheckingCheckweighingSettingId;
            return View(tableCheckingProcedure);
        }

        // POST: TableCheckingProcedures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TableCheckingProcedure tableCheckingProcedure)
        {
            if (id != tableCheckingProcedure.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tableCheckingProcedure);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TableCheckingProcedureExists(tableCheckingProcedure.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "FormCheckingCheckweighingSettings", new {id = tableCheckingProcedure.FormCheckingCheckweighingSettingId});
            }
            ViewData["ExecutorId"] = new SelectList(_context.Users, "Id", "FullName", tableCheckingProcedure.ExecutorId);
            ViewData["FormCheckingCheckweighingSettingId"] = new SelectList(_context.FormCheckingCheckweighingSettings, "Id", "Id", tableCheckingProcedure.FormCheckingCheckweighingSettingId);
            return View(tableCheckingProcedure);
        }

        // GET: TableCheckingProcedures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableCheckingProcedure = await _context.CheckingProcedures
                .Include(t => t.Executor)
                .Include(t => t.FormCheckingCheckweighingSetting)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableCheckingProcedure == null)
            {
                return NotFound();
            }

            return View(tableCheckingProcedure);
        }

        // POST: TableCheckingProcedures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tableCheckingProcedure = await _context.CheckingProcedures
                .FindAsync(id);
            _context.CheckingProcedures.Remove(tableCheckingProcedure);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "FormCheckingCheckweighingSettings", new {id=tableCheckingProcedure.FormCheckingCheckweighingSettingId});
        }

        private bool TableCheckingProcedureExists(int id)
        {
            return _context.CheckingProcedures.Any(e => e.Id == id);
        }
    }
}
