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
    public class TableSettingUpTechnologicalEquipmentsController : Controller
    {
        private readonly ApplicationContext _context;

        public TableSettingUpTechnologicalEquipmentsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: TableSettingUpTechnologicalEquipments
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.SettingUpTechnologicalEquipments.Include(t => t.FormSettingUpTechnologicalEquipment).Include(t => t.ServiceTechnician);
            return View(await applicationContext.ToListAsync());
        }

        // GET: TableSettingUpTechnologicalEquipments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableSettingUpTechnologicalEquipment = await _context.SettingUpTechnologicalEquipments
                .Include(t => t.FormSettingUpTechnologicalEquipment)
                .Include(t => t.ServiceTechnician)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableSettingUpTechnologicalEquipment == null)
            {
                return NotFound();
            }

            return View(tableSettingUpTechnologicalEquipment);
        }

        // GET: TableSettingUpTechnologicalEquipments/Create
        public IActionResult Create()
        {
            ViewData["FormSettingUpTechnologicalEquipmentId"] = new SelectList(_context.FormSettingUpTechnologicalEquipments, "Id", "Id");
            ViewData["ServiceTechnicianId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: TableSettingUpTechnologicalEquipments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FormSettingUpTechnologicalEquipmentId,IsActive,Action,IsApproved,ServiceTechnicianId")] TableSettingUpTechnologicalEquipment tableSettingUpTechnologicalEquipment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tableSettingUpTechnologicalEquipment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FormSettingUpTechnologicalEquipmentId"] = new SelectList(_context.FormSettingUpTechnologicalEquipments, "Id", "Id", tableSettingUpTechnologicalEquipment.FormSettingUpTechnologicalEquipmentId);
            ViewData["ServiceTechnicianId"] = new SelectList(_context.Users, "Id", "Id", tableSettingUpTechnologicalEquipment.ServiceTechnicianId);
            return View(tableSettingUpTechnologicalEquipment);
        }

        // GET: TableSettingUpTechnologicalEquipments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableSettingUpTechnologicalEquipment = await _context.SettingUpTechnologicalEquipments.FindAsync(id);
            if (tableSettingUpTechnologicalEquipment == null)
            {
                return NotFound();
            }
            ViewData["FormSettingUpTechnologicalEquipmentId"] = new SelectList(_context.FormSettingUpTechnologicalEquipments, "Id", "Id", tableSettingUpTechnologicalEquipment.FormSettingUpTechnologicalEquipmentId);
            ViewData["ServiceTechnicianId"] = new SelectList(_context.Users, "Id", "FullName", tableSettingUpTechnologicalEquipment.ServiceTechnicianId);
            return View(tableSettingUpTechnologicalEquipment);
        }

        // POST: TableSettingUpTechnologicalEquipments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TableSettingUpTechnologicalEquipment tableSettingUpTechnologicalEquipment)
        {
            if (id != tableSettingUpTechnologicalEquipment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tableSettingUpTechnologicalEquipment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TableSettingUpTechnologicalEquipmentExists(tableSettingUpTechnologicalEquipment.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "FormSettingUpTechnologicalEquipments", new { id = tableSettingUpTechnologicalEquipment.FormSettingUpTechnologicalEquipmentId });
            }
            ViewData["FormSettingUpTechnologicalEquipmentId"] = new SelectList(_context.FormSettingUpTechnologicalEquipments, "Id", "Id", tableSettingUpTechnologicalEquipment.FormSettingUpTechnologicalEquipmentId);
            ViewData["ServiceTechnicianId"] = new SelectList(_context.Users, "Id", "Id", tableSettingUpTechnologicalEquipment.ServiceTechnicianId);
            return View(tableSettingUpTechnologicalEquipment);
        }

        // GET: TableSettingUpTechnologicalEquipments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableSettingUpTechnologicalEquipment = await _context.SettingUpTechnologicalEquipments
                .Include(t => t.FormSettingUpTechnologicalEquipment)
                .Include(t => t.ServiceTechnician)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableSettingUpTechnologicalEquipment == null)
            {
                return NotFound();
            }

            return View(tableSettingUpTechnologicalEquipment);
        }

        // POST: TableSettingUpTechnologicalEquipments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tableSettingUpTechnologicalEquipment = await _context.SettingUpTechnologicalEquipments.FindAsync(id);
            _context.SettingUpTechnologicalEquipments.Remove(tableSettingUpTechnologicalEquipment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TableSettingUpTechnologicalEquipmentExists(int id)
        {
            return _context.SettingUpTechnologicalEquipments.Any(e => e.Id == id);
        }
    }
}
