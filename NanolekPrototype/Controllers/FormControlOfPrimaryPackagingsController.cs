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
    public class FormControlOfPrimaryPackagingsController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IPackingProtocolService _packingProtocolService;

        public FormControlOfPrimaryPackagingsController(ApplicationContext context, UserManager<User> userManager, IPackingProtocolService packingProtocolService)
        {
            _context = context;
            _userManager = userManager;
            _packingProtocolService = packingProtocolService;
        }


        public async Task<JsonResult> ApproveForm(int? id)
        {
            var form = await _context.FormControlOfPrimaryPackagings
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
            var form = await _context.FormControlOfPrimaryPackagings
                .Include(form => form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            form.Status = FormStatus.OnControl;
            await _context.SaveChangesAsync();

            return _packingProtocolService.AjaxResponse(form);
        }

        [HttpGet]
        public async Task<IActionResult> SendOnRevisionForm(int? id)
        {
            var form = await _context.FormControlOfPrimaryPackagings
                .Include(x => x.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            return View(form);
        }

        [HttpPost]
        public async Task<IActionResult> SendOnRevisionForm(int? id, FormControlOfPrimaryPackaging formControlOfPrimaryPackaging)
        {
            var form = await _context.FormControlOfPrimaryPackagings
                .Include(form => form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            form.Status = FormStatus.OnCompletion;
            form.Note = formControlOfPrimaryPackaging.Note;
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "PackagingProtocols", new { id = form.PackagingProtocol.Id });
        }

        // GET: FormControlOfPrimaryPackagings
        public async Task<IActionResult> Index()
        {
            return View(await _context.FormControlOfPrimaryPackagings.ToListAsync());
        }

        // GET: FormControlOfPrimaryPackagings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formControlOfPrimaryPackaging = await _context.FormControlOfPrimaryPackagings
                .Include(m=>m.PackagingProtocol)
                .Include(m=>m.PackagingControls)
                .ThenInclude(t=>t.TaskMaster)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formControlOfPrimaryPackaging == null)
            {
                return NotFound();
            }

            return View(formControlOfPrimaryPackaging);
        }

        // GET: FormControlOfPrimaryPackagings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormControlOfPrimaryPackagings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsActive,Guid,Status,Note")] FormControlOfPrimaryPackaging formControlOfPrimaryPackaging)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formControlOfPrimaryPackaging);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formControlOfPrimaryPackaging);
        }

        // GET: FormControlOfPrimaryPackagings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formControlOfPrimaryPackaging = await _context.FormControlOfPrimaryPackagings.FindAsync(id);
            if (formControlOfPrimaryPackaging == null)
            {
                return NotFound();
            }
            return View(formControlOfPrimaryPackaging);
        }

        // POST: FormControlOfPrimaryPackagings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsActive,Guid,Status,Note")] FormControlOfPrimaryPackaging formControlOfPrimaryPackaging)
        {
            if (id != formControlOfPrimaryPackaging.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formControlOfPrimaryPackaging);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormControlOfPrimaryPackagingExists(formControlOfPrimaryPackaging.Id))
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
            return View(formControlOfPrimaryPackaging);
        }

        // GET: FormControlOfPrimaryPackagings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formControlOfPrimaryPackaging = await _context.FormControlOfPrimaryPackagings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formControlOfPrimaryPackaging == null)
            {
                return NotFound();
            }

            return View(formControlOfPrimaryPackaging);
        }

        // POST: FormControlOfPrimaryPackagings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formControlOfPrimaryPackaging = await _context.FormControlOfPrimaryPackagings.FindAsync(id);
            _context.FormControlOfPrimaryPackagings.Remove(formControlOfPrimaryPackaging);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormControlOfPrimaryPackagingExists(int id)
        {
            return _context.FormControlOfPrimaryPackagings.Any(e => e.Id == id);
        }
    }
}
