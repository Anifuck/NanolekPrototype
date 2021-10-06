using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NanolekPrototype.Context;
using NanolekPrototype.EntityModels.Enums;
using NanolekPrototype.EntityModels.Models;
using NanolekPrototype.Services;

namespace NanolekPrototype.Controllers
{
    public class FormSettingUpTechnologicalEquipmentsController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IPackingProtocolService _packingProtocolService;

        public FormSettingUpTechnologicalEquipmentsController(ApplicationContext context, UserManager<User> userManager, IPackingProtocolService packingProtocolService)
        {
            _context = context;
            _userManager = userManager;
            _packingProtocolService = packingProtocolService;
        }

        public async Task<JsonResult> ApproveForm(int? id)
        {
            var form = await _context.FormSettingUpTechnologicalEquipments
                .Include(form => form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            form.Status = FormStatus.Approved;
            await _context.SaveChangesAsync();
            await _packingProtocolService.CheckProtocolStatus(form.PackagingProtocol.Id);


            return _packingProtocolService.AjaxResponse(form);
        }

        public async Task<JsonResult> SendOnControlForm(int? id)
        {
            var form = await _context.FormSettingUpTechnologicalEquipments
                .Include(form => form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            form.Status = FormStatus.OnControl;
            await _context.SaveChangesAsync();

            return _packingProtocolService.AjaxResponse(form);
        }

        [HttpGet]
        public async Task<IActionResult> SendOnRevisionForm(int? id)
        {
            var form = await _context.FormSettingUpTechnologicalEquipments
                .Include(x => x.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            return View(form);
        }

        [HttpPost]
        public async Task<IActionResult> SendOnRevisionForm(int? id, FormSettingUpTechnologicalEquipment formSettingUpTechnologicalEquipment)
        {
            var form = await _context.FormSettingUpTechnologicalEquipments
                .Include(form => form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            form.Status = FormStatus.OnCompletion;
            form.Note = formSettingUpTechnologicalEquipment.Note;
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "PackagingProtocols", new { id = form.PackagingProtocol.Id });
        }

        // GET: FormSettingUpTechnologicalEquipments
        public async Task<IActionResult> Index()
        {
            return View(await _context.FormSettingUpTechnologicalEquipments.ToListAsync());
        }

        // GET: FormSettingUpTechnologicalEquipments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formSettingUpTechnologicalEquipment = await _context.FormSettingUpTechnologicalEquipments
                .Include(m=>m.SettingUpTechnologicalEquipments)
                .ThenInclude(tab=>tab.ServiceTechnician)
                .Include(m=>m.PackagingProtocol)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formSettingUpTechnologicalEquipment == null)
            {
                return NotFound();
            }

            return View(formSettingUpTechnologicalEquipment);
        }

        // GET: FormSettingUpTechnologicalEquipments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormSettingUpTechnologicalEquipments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsActive,Guid,Status,Note")] FormSettingUpTechnologicalEquipment formSettingUpTechnologicalEquipment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formSettingUpTechnologicalEquipment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formSettingUpTechnologicalEquipment);
        }

        // GET: FormSettingUpTechnologicalEquipments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formSettingUpTechnologicalEquipment = await _context.FormSettingUpTechnologicalEquipments.FindAsync(id);
            if (formSettingUpTechnologicalEquipment == null)
            {
                return NotFound();
            }
            return View(formSettingUpTechnologicalEquipment);
        }

        // POST: FormSettingUpTechnologicalEquipments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsActive,Guid,Status,Note")] FormSettingUpTechnologicalEquipment formSettingUpTechnologicalEquipment)
        {
            if (id != formSettingUpTechnologicalEquipment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formSettingUpTechnologicalEquipment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormSettingUpTechnologicalEquipmentExists(formSettingUpTechnologicalEquipment.Id))
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
            return View(formSettingUpTechnologicalEquipment);
        }

        // GET: FormSettingUpTechnologicalEquipments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formSettingUpTechnologicalEquipment = await _context.FormSettingUpTechnologicalEquipments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formSettingUpTechnologicalEquipment == null)
            {
                return NotFound();
            }

            return View(formSettingUpTechnologicalEquipment);
        }

        // POST: FormSettingUpTechnologicalEquipments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formSettingUpTechnologicalEquipment = await _context.FormSettingUpTechnologicalEquipments.FindAsync(id);
            _context.FormSettingUpTechnologicalEquipments.Remove(formSettingUpTechnologicalEquipment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormSettingUpTechnologicalEquipmentExists(int id)
        {
            return _context.FormSettingUpTechnologicalEquipments.Any(e => e.Id == id);
        }
    }
}
