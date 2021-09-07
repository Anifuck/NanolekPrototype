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
    public class TableReceptionOfMaterialsController : Controller
    {
        private readonly ApplicationContext _context;

        public TableReceptionOfMaterialsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: TableReceptionOfMaterials
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.ReceptionOfMaterials.Include(t => t.FormReceptionAndMovementOfPackingMaterial);
            return View(await applicationContext.ToListAsync());
        }

        // GET: TableReceptionOfMaterials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableReceptionOfMaterial = await _context.ReceptionOfMaterials
                .Include(t => t.FormReceptionAndMovementOfPackingMaterial)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableReceptionOfMaterial == null)
            {
                return NotFound();
            }

            return View(tableReceptionOfMaterial);
        }

        // GET: TableReceptionOfMaterials/Create
        public IActionResult Create()
        {
            ViewData["FormReceptionAndMovementOfPackingMaterialId"] = new SelectList(_context.FormReceptionAndMovementOfPackingMaterials, "Id", "Id");
            return View();
        }

        // POST: TableReceptionOfMaterials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FormReceptionAndMovementOfPackingMaterialId,IsActive,Date,ReceivedFoil,RemainingProduction,SAPPart,ManufacturerSerialNumber,AnalyticalSheetNumberOKK,IsFoilMeetsControlParameters")] TableReceptionOfMaterial tableReceptionOfMaterial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tableReceptionOfMaterial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FormReceptionAndMovementOfPackingMaterialId"] = new SelectList(_context.FormReceptionAndMovementOfPackingMaterials, "Id", "Id", tableReceptionOfMaterial.FormReceptionAndMovementOfPackingMaterialId);
            return View(tableReceptionOfMaterial);
        }

        // GET: TableReceptionOfMaterials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableReceptionOfMaterial = await _context.ReceptionOfMaterials.FindAsync(id);
            if (tableReceptionOfMaterial == null)
            {
                return NotFound();
            }
            ViewData["FormReceptionAndMovementOfPackingMaterialId"] = new SelectList(_context.FormReceptionAndMovementOfPackingMaterials, "Id", "Id", tableReceptionOfMaterial.FormReceptionAndMovementOfPackingMaterialId);
            return View(tableReceptionOfMaterial);
        }

        // POST: TableReceptionOfMaterials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FormReceptionAndMovementOfPackingMaterialId,IsActive,Date,ReceivedFoil,RemainingProduction,SAPPart,ManufacturerSerialNumber,AnalyticalSheetNumberOKK,IsFoilMeetsControlParameters")] TableReceptionOfMaterial tableReceptionOfMaterial)
        {
            if (id != tableReceptionOfMaterial.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tableReceptionOfMaterial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TableReceptionOfMaterialExists(tableReceptionOfMaterial.Id))
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
            ViewData["FormReceptionAndMovementOfPackingMaterialId"] = new SelectList(_context.FormReceptionAndMovementOfPackingMaterials, "Id", "Id", tableReceptionOfMaterial.FormReceptionAndMovementOfPackingMaterialId);
            return View(tableReceptionOfMaterial);
        }

        // GET: TableReceptionOfMaterials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableReceptionOfMaterial = await _context.ReceptionOfMaterials
                .Include(t => t.FormReceptionAndMovementOfPackingMaterial)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableReceptionOfMaterial == null)
            {
                return NotFound();
            }

            return View(tableReceptionOfMaterial);
        }

        // POST: TableReceptionOfMaterials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tableReceptionOfMaterial = await _context.ReceptionOfMaterials.FindAsync(id);
            _context.ReceptionOfMaterials.Remove(tableReceptionOfMaterial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TableReceptionOfMaterialExists(int id)
        {
            return _context.ReceptionOfMaterials.Any(e => e.Id == id);
        }
    }
}
