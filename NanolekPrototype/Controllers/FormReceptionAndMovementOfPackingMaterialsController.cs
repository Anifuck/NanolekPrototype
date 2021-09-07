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
    public class FormReceptionAndMovementOfPackingMaterialsController : Controller
    {
        private readonly ApplicationContext _context;

        public FormReceptionAndMovementOfPackingMaterialsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: FormReceptionAndMovementOfPackingMaterials
        public async Task<IActionResult> Index()
        {
            return View(await _context.FormReceptionAndMovementOfPackingMaterials.ToListAsync());
        }

        // GET: FormReceptionAndMovementOfPackingMaterials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formReceptionAndMovementOfPackingMaterial = await _context.FormReceptionAndMovementOfPackingMaterials
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formReceptionAndMovementOfPackingMaterial == null)
            {
                return NotFound();
            }

            return View(formReceptionAndMovementOfPackingMaterial);
        }

        // GET: FormReceptionAndMovementOfPackingMaterials/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormReceptionAndMovementOfPackingMaterials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsActive,FormStatus,InternalCodeOfMaterial,Specification,CalcedByUserDate,CheckedByUserDate,SpentOnBatch,RemainingMaterial,IsSentToStorage,IsStoredInProduction,ExpenseFor1000Packs,IsCorrespondsToConsumptionRate,Reconciliation,IsCorrespondenceEligibilityCriteria,Observations,Date,Guid,Status,Note")] FormReceptionAndMovementOfPackingMaterial formReceptionAndMovementOfPackingMaterial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formReceptionAndMovementOfPackingMaterial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formReceptionAndMovementOfPackingMaterial);
        }

        // GET: FormReceptionAndMovementOfPackingMaterials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formReceptionAndMovementOfPackingMaterial = await _context.FormReceptionAndMovementOfPackingMaterials.FindAsync(id);
            if (formReceptionAndMovementOfPackingMaterial == null)
            {
                return NotFound();
            }
            return View(formReceptionAndMovementOfPackingMaterial);
        }

        // POST: FormReceptionAndMovementOfPackingMaterials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsActive,FormStatus,InternalCodeOfMaterial,Specification,CalcedByUserDate,CheckedByUserDate,SpentOnBatch,RemainingMaterial,IsSentToStorage,IsStoredInProduction,ExpenseFor1000Packs,IsCorrespondsToConsumptionRate,Reconciliation,IsCorrespondenceEligibilityCriteria,Observations,Date,Guid,Status,Note")] FormReceptionAndMovementOfPackingMaterial formReceptionAndMovementOfPackingMaterial)
        {
            if (id != formReceptionAndMovementOfPackingMaterial.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formReceptionAndMovementOfPackingMaterial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormReceptionAndMovementOfPackingMaterialExists(formReceptionAndMovementOfPackingMaterial.Id))
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
            return View(formReceptionAndMovementOfPackingMaterial);
        }

        // GET: FormReceptionAndMovementOfPackingMaterials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formReceptionAndMovementOfPackingMaterial = await _context.FormReceptionAndMovementOfPackingMaterials
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formReceptionAndMovementOfPackingMaterial == null)
            {
                return NotFound();
            }

            return View(formReceptionAndMovementOfPackingMaterial);
        }

        // POST: FormReceptionAndMovementOfPackingMaterials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formReceptionAndMovementOfPackingMaterial = await _context.FormReceptionAndMovementOfPackingMaterials.FindAsync(id);
            _context.FormReceptionAndMovementOfPackingMaterials.Remove(formReceptionAndMovementOfPackingMaterial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormReceptionAndMovementOfPackingMaterialExists(int id)
        {
            return _context.FormReceptionAndMovementOfPackingMaterials.Any(e => e.Id == id);
        }
    }
}
