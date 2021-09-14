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
    public class FormMaterialBalanceOfGPByLotsController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IPackingProtocolService _packingProtocolService;

        public FormMaterialBalanceOfGPByLotsController(ApplicationContext context, UserManager<User> userManager, IPackingProtocolService packingProtocolService)
        {
            _context = context;
            _userManager = userManager;
            _packingProtocolService = packingProtocolService;
        }

        public async Task<JsonResult> ApproveForm(int? id)
        {
            var form = await _context.FormMaterialBalanceOfGpByLots
                .Include(form => form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            form.Status = FormStatus.Approved;
            form.CheckedByUserDate = DateTime.Now;
            form.CheckedByUser = user;
            form.CalcedByUserDate = DateTime.Now;
            form.CalcedByUser = user;
            await _context.SaveChangesAsync();
            await _packingProtocolService.CheckProtocolStatus(form.PackagingProtocol.Id);

            return _packingProtocolService.AjaxResponse(form);
        }

        public async Task<IActionResult> SendOnControlForm(int? id)
        {
            var form = await _context.FormMaterialBalanceOfGpByLots
                .Include(form => form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            form.Status = FormStatus.OnControl;
            await _context.SaveChangesAsync();

            return _packingProtocolService.AjaxResponse(form);
        }

        [HttpGet]
        public async Task<IActionResult> SendOnRevisionForm(int? id)
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendOnRevisionForm(int? id, FormMaterialBalanceOfGPByLot formMaterialBalanceOfGpByLot)
        {
            var form = await _context.FormMaterialBalanceOfGpByLots
                .Include(form => form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            form.Status = FormStatus.InWork;
            form.Note = formMaterialBalanceOfGpByLot.Note;
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "PackagingProtocols", new { id = form.PackagingProtocol.Id });
        }


        [HttpGet]
        public async Task<IActionResult> LoadFromSeavision(int id)
        {
            var form = await _context.FormMaterialBalanceOfGpByLots.FirstOrDefaultAsync(f => f.Id == id);
            return PartialView(form);
        }

        [HttpPost]
        public async Task<IActionResult> LoadFromSeavision(int id, FormMaterialBalanceOfGPByLot formMaterialBalanceOfGpByLot)
        {
            var form = await _context.FormMaterialBalanceOfGpByLots.FirstOrDefaultAsync(f => f.Id == id);
            form.StartDateOfPacking = DateTime.Now.AddDays(-3);
            form.FinishDateOfPacking = DateTime.Now;
            form.PackagesCount = 8700;
            await _context.SaveChangesAsync();
            return RedirectToAction("Details","FormMaterialBalanceOfGPByLots" , new {id = id});
        }

        // GET: FormMaterialBalanceOfGPByLots
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.FormMaterialBalanceOfGpByLots.Include(f => f.CalcedByUser).Include(f => f.CheckedByUser).Include(f => f.CheckedPUByUser).Include(f => f.ShiftMaster).Include(f => f.TaskMaster);
            return View(await applicationContext.ToListAsync());
        }

        // GET: FormMaterialBalanceOfGPByLots/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formMaterialBalanceOfGPByLot = await _context.FormMaterialBalanceOfGpByLots
                .Include(f => f.PackagingProtocol)
                .Include(f => f.CalcedByUser)
                .Include(f => f.CheckedByUser)
                .Include(f => f.CheckedPUByUser)
                .Include(f => f.ShiftMaster)
                .Include(f => f.TaskMaster)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formMaterialBalanceOfGPByLot == null)
            {
                return NotFound();
            }

            return View(formMaterialBalanceOfGPByLot);
        }

        // GET: FormMaterialBalanceOfGPByLots/Create
        public IActionResult Create()
        {
            ViewData["CalcedByUserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["CheckedByUserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["CheckedPUByUserId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["ShiftMasterId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["TaskMasterId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: FormMaterialBalanceOfGPByLots/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StartDateOfPacking,FinishDateOfPacking,ShiftMasterId,ShiftMasterDate,CalcedByUserId,CalcedByUserDate,CheckedByUserId,CheckedByUserDate,CheckedPUByUserId,CheckedPUByUserDate,PackagesCount,ExitAccordingToTheRegulations,IsCompliant,Observations,TaskMasterId,Date,Id,IsActive,Guid,Status,Note")] FormMaterialBalanceOfGPByLot formMaterialBalanceOfGPByLot)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formMaterialBalanceOfGPByLot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CalcedByUserId"] = new SelectList(_context.Users, "Id", "Id", formMaterialBalanceOfGPByLot.CalcedByUserId);
            ViewData["CheckedByUserId"] = new SelectList(_context.Users, "Id", "Id", formMaterialBalanceOfGPByLot.CheckedByUserId);
            ViewData["CheckedPUByUserId"] = new SelectList(_context.Users, "Id", "Id", formMaterialBalanceOfGPByLot.CheckedPUByUserId);
            ViewData["ShiftMasterId"] = new SelectList(_context.Users, "Id", "Id", formMaterialBalanceOfGPByLot.ShiftMasterId);
            ViewData["TaskMasterId"] = new SelectList(_context.Users, "Id", "Id", formMaterialBalanceOfGPByLot.TaskMasterId);
            return View(formMaterialBalanceOfGPByLot);
        }

        // GET: FormMaterialBalanceOfGPByLots/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formMaterialBalanceOfGPByLot = await _context.FormMaterialBalanceOfGpByLots.FindAsync(id);
            if (formMaterialBalanceOfGPByLot == null)
            {
                return NotFound();
            }
            ViewData["CalcedByUserId"] = new SelectList(_context.Users, "Id", "FullName", formMaterialBalanceOfGPByLot.CalcedByUserId);
            ViewData["CheckedByUserId"] = new SelectList(_context.Users, "Id", "FullName", formMaterialBalanceOfGPByLot.CheckedByUserId);
            ViewData["CheckedPUByUserId"] = new SelectList(_context.Users, "Id", "FullName", formMaterialBalanceOfGPByLot.CheckedPUByUserId);
            ViewData["ShiftMasterId"] = new SelectList(_context.Users, "Id", "FullName", formMaterialBalanceOfGPByLot.ShiftMasterId);
            ViewData["TaskMasterId"] = new SelectList(_context.Users, "Id", "FullName", formMaterialBalanceOfGPByLot.TaskMasterId);
            return View(formMaterialBalanceOfGPByLot);
        }

        // POST: FormMaterialBalanceOfGPByLots/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, FormMaterialBalanceOfGPByLot formMaterialBalanceOfGPByLot)
        {
            if (id != formMaterialBalanceOfGPByLot.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formMaterialBalanceOfGPByLot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormMaterialBalanceOfGPByLotExists(formMaterialBalanceOfGPByLot.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "FormMaterialBalanceOfGPByLots", new {id = formMaterialBalanceOfGPByLot.Id});
            }
            ViewData["CalcedByUserId"] = new SelectList(_context.Users, "Id", "FullName", formMaterialBalanceOfGPByLot.CalcedByUserId);
            ViewData["CheckedByUserId"] = new SelectList(_context.Users, "Id", "FullName", formMaterialBalanceOfGPByLot.CheckedByUserId);
            ViewData["CheckedPUByUserId"] = new SelectList(_context.Users, "Id", "FullName", formMaterialBalanceOfGPByLot.CheckedPUByUserId);
            ViewData["ShiftMasterId"] = new SelectList(_context.Users, "Id", "FullName", formMaterialBalanceOfGPByLot.ShiftMasterId);
            ViewData["TaskMasterId"] = new SelectList(_context.Users, "Id", "FullName", formMaterialBalanceOfGPByLot.TaskMasterId);
            return View(formMaterialBalanceOfGPByLot);
        }

        // GET: FormMaterialBalanceOfGPByLots/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formMaterialBalanceOfGPByLot = await _context.FormMaterialBalanceOfGpByLots
                .Include(f => f.CalcedByUser)
                .Include(f => f.CheckedByUser)
                .Include(f => f.CheckedPUByUser)
                .Include(f => f.ShiftMaster)
                .Include(f => f.TaskMaster)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formMaterialBalanceOfGPByLot == null)
            {
                return NotFound();
            }

            return View(formMaterialBalanceOfGPByLot);
        }

        // POST: FormMaterialBalanceOfGPByLots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formMaterialBalanceOfGPByLot = await _context.FormMaterialBalanceOfGpByLots.FindAsync(id);
            _context.FormMaterialBalanceOfGpByLots.Remove(formMaterialBalanceOfGPByLot);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormMaterialBalanceOfGPByLotExists(int id)
        {
            return _context.FormMaterialBalanceOfGpByLots.Any(e => e.Id == id);
        }
    }
}
