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
    public class TableSampleSelectionsController : Controller
    {
        private readonly ApplicationContext _context;

        public TableSampleSelectionsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: TableSampleSelections
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.SampleSelections.Include(t => t.EmployeeOKK).Include(t => t.FormSamplingFinishedProduct);
            return View(await applicationContext.ToListAsync());
        }

        // GET: TableSampleSelections/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableSampleSelection = await _context.SampleSelections
                .Include(t => t.EmployeeOKK)
                .Include(t => t.FormSamplingFinishedProduct)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableSampleSelection == null)
            {
                return NotFound();
            }

            return View(tableSampleSelection);
        }

        // GET: TableSampleSelections/Create
        public IActionResult Create(int formId)
        {
            ViewData["EmployeeOKKId"] = new SelectList(_context.Users, "Id", "FullName");
            ViewData["FormSamplingFinishedProductId"] = formId;
            return View();
        }

        // POST: TableSampleSelections/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TableSampleSelection tableSampleSelection)
        {
            tableSampleSelection.IsActive = true;
            if (ModelState.IsValid)
            {
                _context.Add(tableSampleSelection);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "FormSamplingFinishedProducts", new {id = tableSampleSelection.FormSamplingFinishedProductId});
            }
            ViewData["EmployeeOKKId"] = new SelectList(_context.Users, "Id", "FullName", tableSampleSelection.EmployeeOKKId);
            ViewData["FormSamplingFinishedProductId"] = new SelectList(_context.FormSamplingFinishedProducts, "Id", "Id", tableSampleSelection.FormSamplingFinishedProductId);
            return View(tableSampleSelection);
        }

        // GET: TableSampleSelections/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableSampleSelection = await _context.SampleSelections.FindAsync(id);
            if (tableSampleSelection == null)
            {
                return NotFound();
            }
            ViewData["EmployeeOKKId"] = new SelectList(_context.Users, "Id", "FullName", tableSampleSelection.EmployeeOKKId);
            ViewData["FormSamplingFinishedProductId"] = new SelectList(_context.FormSamplingFinishedProducts, "Id", "Id", tableSampleSelection.FormSamplingFinishedProductId);
            return View(tableSampleSelection);
        }

        // POST: TableSampleSelections/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TableSampleSelection tableSampleSelection)
        {
            if (id != tableSampleSelection.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tableSampleSelection);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TableSampleSelectionExists(tableSampleSelection.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "FormSamplingFinishedProducts", new {id=tableSampleSelection.FormSamplingFinishedProductId});
            }
            ViewData["EmployeeOKKId"] = new SelectList(_context.Users, "Id", "FullName", tableSampleSelection.EmployeeOKKId);
            ViewData["FormSamplingFinishedProductId"] = new SelectList(_context.FormSamplingFinishedProducts, "Id", "Id", tableSampleSelection.FormSamplingFinishedProductId);
            return View(tableSampleSelection);
        }

        // GET: TableSampleSelections/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableSampleSelection = await _context.SampleSelections
                .Include(t => t.EmployeeOKK)
                .Include(t => t.FormSamplingFinishedProduct)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableSampleSelection == null)
            {
                return NotFound();
            }

            return View(tableSampleSelection);
        }

        // POST: TableSampleSelections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tableSampleSelection = await _context.SampleSelections.FindAsync(id);
            _context.SampleSelections.Remove(tableSampleSelection);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "FormSamplingFinishedProducts", new {id = tableSampleSelection.FormSamplingFinishedProductId});
        }

        private bool TableSampleSelectionExists(int id)
        {
            return _context.SampleSelections.Any(e => e.Id == id);
        }
    }
}
