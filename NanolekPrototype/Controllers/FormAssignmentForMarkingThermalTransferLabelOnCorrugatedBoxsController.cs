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
    public class FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxsController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IPackingProtocolService _packingProtocolService;

        public FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxsController(ApplicationContext context, UserManager<User> userManager, IPackingProtocolService packingProtocolService)
        {
            _context = context;
            _userManager = userManager;
            _packingProtocolService = packingProtocolService;
        }

        public async Task<JsonResult> ApproveForm(int? id)
        {
            var form = await _context.FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox
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
            var form = await _context.FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox
                .Include(form => form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            form.Status = FormStatus.OnControl;
            await _context.SaveChangesAsync();

            return _packingProtocolService.AjaxResponse(form);
        }

        [HttpGet]
        public async Task<IActionResult> SendOnRevisionForm(int? id)
        {
            var form = await _context.FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox
                .Include(x => x.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            return View(form);
        }

        [HttpPost]
        public async Task<IActionResult> SendOnRevisionForm(int? id, FormReceptionAndMovementOfBulkProduct formReceptionAndMovementOfBulkProduct)
        {
            var form = await _context.FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox
                .Include(form => form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            form.Status = FormStatus.OnCompletion;
            form.Note = formReceptionAndMovementOfBulkProduct.Note;
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "PackagingProtocols", new { id = form.PackagingProtocol.Id });
        }

        // GET: FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxes
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox.Include(f => f.TaskGiven).Include(f => f.TaskGot);
            return View(await applicationContext.ToListAsync());
        }

        // GET: FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox = await _context.FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox
                .Include(f=>f.PackagingProtocol)
                .Include(f => f.TaskGiven)
                .Include(f => f.TaskGot)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox == null)
            {
                return NotFound();
            }

            return View(formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox);
        }

        // GET: FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxes/Create
        public IActionResult Create()
        {
            ViewData["TaskGivenId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["TaskGotId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GTIN,Series,DateOfManufacture,SellBy,PacksInCorrugatedBox,InternalCode,TaskGivenId,TaskGivenDate,TaskGotId,TaskGotDate,Id,IsActive,Guid,Status,Note")] FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TaskGivenId"] = new SelectList(_context.Users, "Id", "FullName", formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox.TaskGivenId);
            ViewData["TaskGotId"] = new SelectList(_context.Users, "Id", "FullName", formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox.TaskGotId);
            return View(formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox);
        }

        // GET: FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox = await _context.FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox.FindAsync(id);
            if (formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox == null)
            {
                return NotFound();
            }
            ViewData["TaskGivenId"] = new SelectList(_context.Users, "Id", "FullName", formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox.TaskGivenId);
            ViewData["TaskGotId"] = new SelectList(_context.Users, "Id", "FullName", formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox.TaskGotId);
            return View(formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox);
        }

        // POST: FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox)
        {
            if (id != formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxExists(formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxs", new {id=formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox.Id});
            }
            ViewData["TaskGivenId"] = new SelectList(_context.Users, "Id", "Id", formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox.TaskGivenId);
            ViewData["TaskGotId"] = new SelectList(_context.Users, "Id", "Id", formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox.TaskGotId);
            return View(formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox);
        }

        // GET: FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox = await _context.FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox
                .Include(f => f.TaskGiven)
                .Include(f => f.TaskGot)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox == null)
            {
                return NotFound();
            }

            return View(formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox);
        }

        // POST: FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox = await _context.FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox.FindAsync(id);
            _context.FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox.Remove(formAssignmentForMarkingThermalTransferLabelOnCorrugatedBox);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxExists(int id)
        {
            return _context.FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox.Any(e => e.Id == id);
        }
    }
}
