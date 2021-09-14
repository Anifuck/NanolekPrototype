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
    public class TableProceduresController : Controller
    {
        private readonly ApplicationContext _context;

        public TableProceduresController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: TableProcedures
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.TabeProcedures.Include(t => t.Checker).Include(t => t.Executor).Include(t => t.FormSamplingFinishedProduct);
            return View(await applicationContext.ToListAsync());
        }

        // GET: TableProcedures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableProcedure = await _context.TabeProcedures
                .Include(t => t.Checker)
                .Include(t => t.Executor)
                .Include(t => t.FormSamplingFinishedProduct)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableProcedure == null)
            {
                return NotFound();
            }

            return View(tableProcedure);
        }

        // GET: TableProcedures/Create
        public IActionResult Create()
        {
            ViewData["CheckerId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["ExecutorId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["FormSamplingFinishedProductId"] = new SelectList(_context.FormSamplingFinishedProducts, "Id", "Id");
            return View();
        }

        // POST: TableProcedures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FormSamplingFinishedProductId,IsActive,Procedure,IsCompleted,ExecutorId,CheckerId")] TableProcedure tableProcedure)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tableProcedure);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CheckerId"] = new SelectList(_context.Users, "Id", "Id", tableProcedure.CheckerId);
            ViewData["ExecutorId"] = new SelectList(_context.Users, "Id", "Id", tableProcedure.ExecutorId);
            ViewData["FormSamplingFinishedProductId"] = new SelectList(_context.FormSamplingFinishedProducts, "Id", "Id", tableProcedure.FormSamplingFinishedProductId);
            return View(tableProcedure);
        }

        // GET: TableProcedures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableProcedure = await _context.TabeProcedures.FindAsync(id);
            if (tableProcedure == null)
            {
                return NotFound();
            }
            ViewData["CheckerId"] = new SelectList(_context.Users, "Id", "FullName", tableProcedure.CheckerId);
            ViewData["ExecutorId"] = new SelectList(_context.Users, "Id", "FullName", tableProcedure.ExecutorId);
            ViewData["FormSamplingFinishedProductId"] = new SelectList(_context.FormSamplingFinishedProducts, "Id", "Id", tableProcedure.FormSamplingFinishedProductId);
            return View(tableProcedure);
        }

        // POST: TableProcedures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TableProcedure tableProcedure)
        {
            if (id != tableProcedure.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    tableProcedure.ProcedureMarkDate = DateTime.Now;
                    _context.Update(tableProcedure);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TableProcedureExists(tableProcedure.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "FormSamplingFinishedProducts", new {id = tableProcedure.FormSamplingFinishedProductId});
            }
            ViewData["CheckerId"] = new SelectList(_context.Users, "Id", "FullName", tableProcedure.CheckerId);
            ViewData["ExecutorId"] = new SelectList(_context.Users, "Id", "FullName", tableProcedure.ExecutorId);
            ViewData["FormSamplingFinishedProductId"] = new SelectList(_context.FormSamplingFinishedProducts, "Id", "Id", tableProcedure.FormSamplingFinishedProductId);
            return View(tableProcedure);
        }

        // GET: TableProcedures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableProcedure = await _context.TabeProcedures
                .Include(t => t.Checker)
                .Include(t => t.Executor)
                .Include(t => t.FormSamplingFinishedProduct)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableProcedure == null)
            {
                return NotFound();
            }

            return View(tableProcedure);
        }

        // POST: TableProcedures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tableProcedure = await _context.TabeProcedures.FindAsync(id);
            _context.TabeProcedures.Remove(tableProcedure);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "FormSamplingFinishedProducts", new {id=tableProcedure.FormSamplingFinishedProductId});
        }

        private bool TableProcedureExists(int id)
        {
            return _context.TabeProcedures.Any(e => e.Id == id);
        }
    }
}
