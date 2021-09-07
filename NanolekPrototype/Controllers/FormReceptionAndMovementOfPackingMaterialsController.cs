using System;
using System.Collections.Generic;
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
    public class FormReceptionAndMovementOfPackingMaterialsController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IPackingProtocolService _packingProtocolService;

        public FormReceptionAndMovementOfPackingMaterialsController(ApplicationContext context, UserManager<User> userManager, IPackingProtocolService packingProtocolService)
        {
            _context = context;
            _userManager = userManager;
            _packingProtocolService = packingProtocolService;
        }

        public async Task<IActionResult> ApproveForm(int? id)
        {
            var form = await _context.FormReceptionAndMovementOfPackingMaterials
                .Include(form=>form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            form.Status = FormStatus.Approved;
            form.CheckedByUserDate = DateTime.Now;
            form.CheckedByUser = user;
            form.CalcedByUserDate = DateTime.Now;
            form.CalcedByUser = user;
            await _context.SaveChangesAsync();
            await _packingProtocolService.CheckProtocolStatus(form.PackagingProtocol.Id);
            return RedirectToAction("Details", "PackagingProtocols", new { id = form.PackagingProtocol.Id });
        }

        public async Task<IActionResult> SendOnControlForm(int? id)
        {
            var form = await _context.FormReceptionAndMovementOfPackingMaterials
                .Include(form=>form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            form.Status = FormStatus.OnControl;
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "PackagingProtocols", new { id = form.PackagingProtocol.Id });
        }

        [HttpGet]
        public async Task<IActionResult> SendOnRevisionForm(int? id)
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendOnRevisionForm(int? id, FormReceptionAndMovementOfPackingMaterial formReceptionAndMovementOfPackingMaterial)
        {
            var form = await _context.FormReceptionAndMovementOfPackingMaterials
                .Include(form=>form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            form.Status = FormStatus.InWork;
            form.Note = formReceptionAndMovementOfPackingMaterial.Note;
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "PackagingProtocols", new { id = form.PackagingProtocol.Id });
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
                .Include(m=>m.ReceptionOfMaterials)
                .ThenInclude(s=>s.ShiftMaster)
                .Include(m=>m.PackagingProtocol)
                .Include(m => m.CalcedByUser)
                .Include(m => m.CheckedByUser)
                .Include(m => m.ShiftMaster)
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

            var formReceptionAndMovementOfPackingMaterial = await _context.FormReceptionAndMovementOfPackingMaterials
               .Include(m => m.PackagingProtocol)
               .Include(m => m.ReceptionOfMaterials)
               .ThenInclude(p => p.ShiftMaster)
               .Include(m => m.CalcedByUser)
               .Include(m => m.CheckedByUser)
               .FirstOrDefaultAsync(m => m.Id == id);

            if (formReceptionAndMovementOfPackingMaterial.CalcedByUser != null)
            {
                ViewBag.CalcedByUsers = _userManager.Users
                    .Select(user => new SelectListItem(user.FullName, user.Id.ToString(),
                        formReceptionAndMovementOfPackingMaterial.CalcedByUser.Id == user.Id))
                    .ToList();
            }
            else
            {
                ViewBag.CalcedByUsers = _userManager.Users
                    .Select(user => new SelectListItem(user.FullName, user.Id.ToString())).ToList();
            }

            if (formReceptionAndMovementOfPackingMaterial.CheckedByUser != null)
            {
                ViewBag.CheckedByUsers = _userManager.Users
                    .Select(user => new SelectListItem(user.FullName, user.Id.ToString(),
                        formReceptionAndMovementOfPackingMaterial.CheckedByUser.Id == user.Id))
                    .ToList();
            }
            else
            {
                ViewBag.CheckedByUsers = _userManager.Users
                    .Select(user => new SelectListItem(user.FullName, user.Id.ToString()))
                    .ToList();
            }


            if (formReceptionAndMovementOfPackingMaterial.ShiftMaster != null)
            {
                ViewBag.ShiftMasters = _userManager.Users
                    .Select(user => new SelectListItem(user.FullName, user.Id.ToString(),
                        formReceptionAndMovementOfPackingMaterial.ShiftMaster.Id == user.Id))
                    .ToList();
            }
            else
            {
                ViewBag.ShiftMasters = _userManager.Users
                    .Select(user => new SelectListItem(user.FullName, user.Id.ToString()))
                    .ToList();
            }



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
        public async Task<IActionResult> Edit(int id, FormReceptionAndMovementOfPackingMaterial formReceptionAndMovementOfPackingMaterial)
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
                return RedirectToAction("Details", new { id = formReceptionAndMovementOfPackingMaterial.Id });
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
