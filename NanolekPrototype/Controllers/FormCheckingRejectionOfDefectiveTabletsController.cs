using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
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
    public class FormCheckingRejectionOfDefectiveTabletsController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IPackingProtocolService _packingProtocolService;

        public FormCheckingRejectionOfDefectiveTabletsController(ApplicationContext context, UserManager<User> userManager, IPackingProtocolService packingProtocolService)
        {
            _context = context;
            _userManager = userManager;
            _packingProtocolService = packingProtocolService;
        }

        public async Task<JsonResult> ApproveForm(int? id)
        {
            var form = await _context.FormCheckingRejectionOfDefectiveTablets
                .Include(form => form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);

            form.Status = FormStatus.Approved;
            await _context.SaveChangesAsync();
            await _packingProtocolService.CheckProtocolStatus(form.PackagingProtocol.Id);

            return _packingProtocolService.AjaxResponse(form);
        }

        public async Task<JsonResult> SendOnControlForm(int? id)
        {
            var form = await _context.FormCheckingRejectionOfDefectiveTablets
                .Include(form => form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            form.Status = FormStatus.OnControl;
            await _context.SaveChangesAsync();

            return _packingProtocolService.AjaxResponse(form);
        }

        [HttpGet]
        public async Task<IActionResult> SendOnRevisionForm(int? id)
        {
            var form = await _context.FormCheckingRejectionOfDefectiveTablets
                .Include(x => x.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            return View(form);
        }

        [HttpPost]
        public async Task<IActionResult> SendOnRevisionForm(int? id, FormReceptionAndMovementOfBulkProduct formReceptionAndMovementOfBulkProduct)
        {
            var form = await _context.FormCheckingRejectionOfDefectiveTablets
                .Include(form => form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            form.Status = FormStatus.OnCompletion;
            form.Note = formReceptionAndMovementOfBulkProduct.Note;
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "PackagingProtocols", new { id = form.PackagingProtocol.Id });
        }

        // GET: FormCheckingRejectionOfDefectiveTablets
        public async Task<IActionResult> Index()
        {
            return View(await _context.FormCheckingRejectionOfDefectiveTablets.ToListAsync());
        }

        // GET: FormCheckingRejectionOfDefectiveTablets/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formCheckingRejectionOfDefectiveTablet = await _context.FormCheckingRejectionOfDefectiveTablets
                .Include(m=>m.PackagingProtocol)
                .Include(m=>m.VerificationActions)
                .ThenInclude(tab=>tab.TaskMaster)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formCheckingRejectionOfDefectiveTablet == null)
            {
                return NotFound();
            }

            return View(formCheckingRejectionOfDefectiveTablet);
        }

        // GET: FormCheckingRejectionOfDefectiveTablets/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormCheckingRejectionOfDefectiveTablets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CheckingDate,Id,IsActive,Guid,Status,Note")] FormCheckingRejectionOfDefectiveTablet formCheckingRejectionOfDefectiveTablet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formCheckingRejectionOfDefectiveTablet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formCheckingRejectionOfDefectiveTablet);
        }

        // GET: FormCheckingRejectionOfDefectiveTablets/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formCheckingRejectionOfDefectiveTablet = await _context.FormCheckingRejectionOfDefectiveTablets.FindAsync(id);
            if (formCheckingRejectionOfDefectiveTablet == null)
            {
                return NotFound();
            }
            return View(formCheckingRejectionOfDefectiveTablet);
        }

        // POST: FormCheckingRejectionOfDefectiveTablets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, FormCheckingRejectionOfDefectiveTablet formCheckingRejectionOfDefectiveTablet)
        {
            if (id != formCheckingRejectionOfDefectiveTablet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formCheckingRejectionOfDefectiveTablet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormCheckingRejectionOfDefectiveTabletExists(formCheckingRejectionOfDefectiveTablet.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "FormCheckingRejectionOfDefectiveTablets", new {id = formCheckingRejectionOfDefectiveTablet.Id});
            }
            return View(formCheckingRejectionOfDefectiveTablet);
        }

        // GET: FormCheckingRejectionOfDefectiveTablets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formCheckingRejectionOfDefectiveTablet = await _context.FormCheckingRejectionOfDefectiveTablets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formCheckingRejectionOfDefectiveTablet == null)
            {
                return NotFound();
            }

            return View(formCheckingRejectionOfDefectiveTablet);
        }

        // POST: FormCheckingRejectionOfDefectiveTablets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formCheckingRejectionOfDefectiveTablet = await _context.FormCheckingRejectionOfDefectiveTablets.FindAsync(id);
            _context.FormCheckingRejectionOfDefectiveTablets.Remove(formCheckingRejectionOfDefectiveTablet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormCheckingRejectionOfDefectiveTabletExists(int id)
        {
            return _context.FormCheckingRejectionOfDefectiveTablets.Any(e => e.Id == id);
        }
    }
}
