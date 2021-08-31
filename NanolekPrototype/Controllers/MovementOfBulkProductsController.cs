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
    public class MovementOfBulkProductsController : Controller
    {
        private readonly ApplicationContext _context;

        public MovementOfBulkProductsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: MovementOfBulkProducts
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.MovementOfBulkProducts.Include(m => m.FormReceptionAndMovementOfBulkProduct);
            return View(await applicationContext.ToListAsync());
        }

        // GET: MovementOfBulkProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movementOfBulkProduct = await _context.MovementOfBulkProducts
                .Include(m => m.FormReceptionAndMovementOfBulkProduct)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movementOfBulkProduct == null)
            {
                return NotFound();
            }

            return View(movementOfBulkProduct);
        }

        // GET: MovementOfBulkProducts/Create
        public IActionResult Create()
        {
            ViewData["FormReceptionAndMovementOfBulkProductId"] = new SelectList(_context.FormReceptionAndMovementOfBulkProducts, "Id", "Id");
            return View();
        }

        // POST: MovementOfBulkProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FormReceptionAndMovementOfBulkProductId,IsActive,GarbageKg")] MovementOfBulkProduct movementOfBulkProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movementOfBulkProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FormReceptionAndMovementOfBulkProductId"] = new SelectList(_context.FormReceptionAndMovementOfBulkProducts, "Id", "Id", movementOfBulkProduct.FormReceptionAndMovementOfBulkProductId);
            return View(movementOfBulkProduct);
        }

        // GET: MovementOfBulkProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movementOfBulkProduct = await _context.MovementOfBulkProducts.FindAsync(id);
            if (movementOfBulkProduct == null)
            {
                return NotFound();
            }
            ViewData["FormReceptionAndMovementOfBulkProductId"] = new SelectList(_context.FormReceptionAndMovementOfBulkProducts, "Id", "Id", movementOfBulkProduct.FormReceptionAndMovementOfBulkProductId);
            return View(movementOfBulkProduct);
        }

        // POST: MovementOfBulkProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FormReceptionAndMovementOfBulkProductId,IsActive,GarbageKg")] MovementOfBulkProduct movementOfBulkProduct)
        {
            if (id != movementOfBulkProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movementOfBulkProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovementOfBulkProductExists(movementOfBulkProduct.Id))
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
            ViewData["FormReceptionAndMovementOfBulkProductId"] = new SelectList(_context.FormReceptionAndMovementOfBulkProducts, "Id", "Id", movementOfBulkProduct.FormReceptionAndMovementOfBulkProductId);
            return View(movementOfBulkProduct);
        }

        // GET: MovementOfBulkProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movementOfBulkProduct = await _context.MovementOfBulkProducts
                .Include(m => m.FormReceptionAndMovementOfBulkProduct)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (movementOfBulkProduct == null)
            {
                return NotFound();
            }

            return View(movementOfBulkProduct);
        }

        // POST: MovementOfBulkProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movementOfBulkProduct = await _context.MovementOfBulkProducts.FindAsync(id);
            _context.MovementOfBulkProducts.Remove(movementOfBulkProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovementOfBulkProductExists(int id)
        {
            return _context.MovementOfBulkProducts.Any(e => e.Id == id);
        }
    }
}
