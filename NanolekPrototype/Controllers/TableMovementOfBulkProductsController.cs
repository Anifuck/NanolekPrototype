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
    public class TableMovementOfBulkProductsController : Controller
    {
        private readonly ApplicationContext _context;

        public TableMovementOfBulkProductsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: TableMovementOfBulkProducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.MovementOfBulkProducts.ToListAsync());
        }

        // GET: TableMovementOfBulkProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableMovementOfBulkProduct = await _context.MovementOfBulkProducts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableMovementOfBulkProduct == null)
            {
                return NotFound();
            }

            return View(tableMovementOfBulkProduct);
        }

        // GET: TableMovementOfBulkProducts/Create
        public IActionResult Create(int formId)
        {
            ViewData["FormId"] = formId;
            return View();
        }

        // POST: TableMovementOfBulkProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TableMovementOfBulkProduct tableMovementOfBulkProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tableMovementOfBulkProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tableMovementOfBulkProduct);
        }

        // GET: TableMovementOfBulkProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableMovementOfBulkProduct = await _context.MovementOfBulkProducts.FindAsync(id);
            if (tableMovementOfBulkProduct == null)
            {
                return NotFound();
            }
            return View(tableMovementOfBulkProduct);
        }

        // POST: TableMovementOfBulkProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TableMovementOfBulkProduct tableMovementOfBulkProduct)
        {
            tableMovementOfBulkProduct.FormReceptionAndMovementOfBulkProductId = 12;
            if (id != tableMovementOfBulkProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tableMovementOfBulkProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TableMovementOfBulkProductExists(tableMovementOfBulkProduct.Id))
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
            return View(tableMovementOfBulkProduct);
        }

        // GET: TableMovementOfBulkProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableMovementOfBulkProduct = await _context.MovementOfBulkProducts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableMovementOfBulkProduct == null)
            {
                return NotFound();
            }

            return View(tableMovementOfBulkProduct);
        }

        // POST: TableMovementOfBulkProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tableMovementOfBulkProduct = await _context.MovementOfBulkProducts.FindAsync(id);
            _context.MovementOfBulkProducts.Remove(tableMovementOfBulkProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TableMovementOfBulkProductExists(int id)
        {
            return _context.MovementOfBulkProducts.Any(e => e.Id == id);
        }
    }
}
