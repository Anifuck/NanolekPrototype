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
    public class FormCheckingCheckweighingSettingsController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IPackingProtocolService _packingProtocolService;

        public FormCheckingCheckweighingSettingsController(ApplicationContext context, UserManager<User> userManager, IPackingProtocolService packingProtocolService)
        {
            _context = context;
            _userManager = userManager;
            _packingProtocolService = packingProtocolService;
        }

        public async Task<JsonResult> ApproveForm(int? id)
        {
            var form = await _context.FormCheckingCheckweighingSettings
                .Include(form => form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            form.Status = FormStatus.Approved;
            await _context.SaveChangesAsync();
            await _packingProtocolService.CheckProtocolStatus(form.PackagingProtocol.Id);

            var type = typeof(FormStatus);
            var memberInfo = type.GetMember(form.Status.ToString());
            var attributes = memberInfo.First().GetCustomAttributes(typeof(DisplayAttribute), false);
            var description = ((DisplayAttribute)attributes.First()).Name;

            var response = new Response()
            {
                Status = ResponseStatus.ok,
                ProtocolState = description
            };

            return new JsonResult(response);

        }

        public async Task<JsonResult> SendOnControlForm(int? id)
        {
            var form = await _context.FormCheckingCheckweighingSettings
                .Include(form => form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            form.Status = FormStatus.OnControl;
            await _context.SaveChangesAsync();

            var type = typeof(FormStatus);
            var memberInfo = type.GetMember(form.Status.ToString());
            var attributes = memberInfo.First().GetCustomAttributes(typeof(DisplayAttribute), false);
            var description = ((DisplayAttribute)attributes.First()).Name;

            var response = new Response()
            {
                Status = ResponseStatus.ok,
                ProtocolState = description
            };

            return new JsonResult(response);
        }

        [HttpGet]
        public async Task<IActionResult> SendOnRevisionForm(int? id)
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendOnRevisionForm(int? id, FormCheckingCheckweighingSetting formCheckingCheckweighingSetting)
        {
            var form = await _context.FormCheckingCheckweighingSettings
                .Include(form => form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            form.Status = FormStatus.InWork;
            form.Note = formCheckingCheckweighingSetting.Note;
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "PackagingProtocols", new { id = form.PackagingProtocol.Id });
        }

        // GET: FormCheckingCheckweighingSettings
        public async Task<IActionResult> Index()
        {
            return View(await _context.FormCheckingCheckweighingSettings.ToListAsync());
        }

        // GET: FormCheckingCheckweighingSettings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formCheckingCheckweighingSetting = await _context.FormCheckingCheckweighingSettings
                .Include(m=>m.PackagingProtocol)
                .Include(m=>m.CheckingProcedures)
                .ThenInclude(t=>t.Executor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formCheckingCheckweighingSetting == null)
            {
                return NotFound();
            }

            return View(formCheckingCheckweighingSetting);
        }

        // GET: FormCheckingCheckweighingSettings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormCheckingCheckweighingSettings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IsActive,Guid,Status,Note")] FormCheckingCheckweighingSetting formCheckingCheckweighingSetting)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formCheckingCheckweighingSetting);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formCheckingCheckweighingSetting);
        }

        // GET: FormCheckingCheckweighingSettings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formCheckingCheckweighingSetting = await _context.FormCheckingCheckweighingSettings.FindAsync(id);
            if (formCheckingCheckweighingSetting == null)
            {
                return NotFound();
            }
            return View(formCheckingCheckweighingSetting);
        }

        // POST: FormCheckingCheckweighingSettings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsActive,Guid,Status,Note")] FormCheckingCheckweighingSetting formCheckingCheckweighingSetting)
        {
            if (id != formCheckingCheckweighingSetting.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formCheckingCheckweighingSetting);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormCheckingCheckweighingSettingExists(formCheckingCheckweighingSetting.Id))
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
            return View(formCheckingCheckweighingSetting);
        }

        // GET: FormCheckingCheckweighingSettings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formCheckingCheckweighingSetting = await _context.FormCheckingCheckweighingSettings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formCheckingCheckweighingSetting == null)
            {
                return NotFound();
            }

            return View(formCheckingCheckweighingSetting);
        }

        // POST: FormCheckingCheckweighingSettings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formCheckingCheckweighingSetting = await _context.FormCheckingCheckweighingSettings.FindAsync(id);
            _context.FormCheckingCheckweighingSettings.Remove(formCheckingCheckweighingSetting);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormCheckingCheckweighingSettingExists(int id)
        {
            return _context.FormCheckingCheckweighingSettings.Any(e => e.Id == id);
        }
    }
}
