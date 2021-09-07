using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
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

        private readonly UserManager<User> _userManager;

        public TableReceptionOfMaterialsController(ApplicationContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
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
        public IActionResult Create(int formid)
        {
            ViewBag.ShiftMasters = _userManager.Users
                .Select(user => new SelectListItem(user.FullName, user.Id.ToString()))
                .ToList();
            ViewData["FormReceptionAndMovementOfPackingMaterialId"] = formid;
            return View();
        }

        // POST: TableReceptionOfMaterials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TableReceptionOfMaterial tableReceptionOfMaterial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tableReceptionOfMaterial);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "FormReceptionAndMovementOfPackingMaterials", new { id = tableReceptionOfMaterial.FormReceptionAndMovementOfPackingMaterialId });
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

            var tableReceptionOfMaterial =
                await _context.ReceptionOfMaterials
                    .Include(m => m.FormReceptionAndMovementOfPackingMaterial)
                    .Include(m => m.ShiftMaster)
                    .Where(m => m.Id == id)
                    .FirstAsync();

            if (tableReceptionOfMaterial.ShiftMaster != null)
            {
                ViewBag.ShiftMasters = _userManager.Users
                    .Select(user => new SelectListItem(user.FullName, user.Id.ToString(),
                        tableReceptionOfMaterial.ShiftMaster.Id == user.Id))
                    .ToList();
            }
            else
            {
                ViewBag.ShiftMasters = _userManager.Users
                    .Select(user => new SelectListItem(user.FullName, user.Id.ToString()))
                    .ToList();
            }


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
        public async Task<IActionResult> Edit(int id, TableReceptionOfMaterial tableReceptionOfMaterial)
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

                return RedirectToAction("Details", "FormReceptionAndMovementOfPackingMaterials", new {id=tableReceptionOfMaterial.FormReceptionAndMovementOfPackingMaterialId});
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

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tableReceptionOfMaterial = await _context.ReceptionOfMaterials.FindAsync(id);
            _context.ReceptionOfMaterials.Remove(tableReceptionOfMaterial);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "FormReceptionAndMovementOfPackingMaterials", new { id = tableReceptionOfMaterial.FormReceptionAndMovementOfPackingMaterialId });
        }

        private bool TableReceptionOfMaterialExists(int id)
        {
            return _context.ReceptionOfMaterials.Any(e => e.Id == id);
        }
    }
}
