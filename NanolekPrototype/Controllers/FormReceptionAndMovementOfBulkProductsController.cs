using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Web.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Internal.Account.Manage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NanolekPrototype.Context;
using NanolekPrototype.EntityModels.Enums;
using NanolekPrototype.EntityModels.Models;
using NanolekPrototype.Services;

namespace NanolekPrototype.Controllers
{
    public class FormReceptionAndMovementOfBulkProductsController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IPackingProtocolService _packingProtocolService;

        public FormReceptionAndMovementOfBulkProductsController(ApplicationContext context, UserManager<User> userManager, IPackingProtocolService packingProtocolService)
        {
            _context = context;
            _userManager = userManager;
            _packingProtocolService = packingProtocolService;
        }

        public async Task<JsonResult> ApproveForm(int? id)
        {
           var form =  await _context.FormReceptionAndMovementOfBulkProducts
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
        
        public async Task<JsonResult> SendOnControlForm(int? id)
        {
            var form = await _context.FormReceptionAndMovementOfBulkProducts
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
        public async Task<IActionResult> SendOnRevisionForm(int? id, FormReceptionAndMovementOfBulkProduct formReceptionAndMovementOfBulkProduct)
        {
            var form = await _context.FormReceptionAndMovementOfBulkProducts
                .Include(form=>form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            form.Status = FormStatus.InWork;
            form.Note = formReceptionAndMovementOfBulkProduct.Note;
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "PackagingProtocols", new { id = form.PackagingProtocol.Id });
        }

        // GET: FormReceptionAndMovementOfBulkProducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.FormReceptionAndMovementOfBulkProducts.ToListAsync());
        }

        // GET: FormReceptionAndMovementOfBulkProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formReceptionAndMovementOfBulkProduct = await _context.FormReceptionAndMovementOfBulkProducts
                .Include(m=>m.PackagingProtocol)
                .Include(m=>m.MovementOfBulkProducts)
                .ThenInclude(p=>p.Executor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formReceptionAndMovementOfBulkProduct == null)
            {
                return NotFound();
            }

            return View(formReceptionAndMovementOfBulkProduct);
        }

        // GET: FormReceptionAndMovementOfBulkProducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FormReceptionAndMovementOfBulkProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(FormReceptionAndMovementOfBulkProduct formReceptionAndMovementOfBulkProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formReceptionAndMovementOfBulkProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(formReceptionAndMovementOfBulkProduct);
        }

        // GET: FormReceptionAndMovementOfBulkProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formReceptionAndMovementOfBulkProduct = await _context.FormReceptionAndMovementOfBulkProducts
                .Include(m => m.PackagingProtocol)
                .Include(m => m.MovementOfBulkProducts)
                .ThenInclude(p => p.Executor)
                .Include(m=>m.CalcedByUser)
                .Include(m=>m.CheckedByUser)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (formReceptionAndMovementOfBulkProduct.CalcedByUser != null)
            {
                ViewBag.CalcedByUsers = _userManager.Users
                    .Select(user => new SelectListItem(user.FullName, user.Id.ToString(),
                        formReceptionAndMovementOfBulkProduct.CalcedByUser.Id == user.Id))
                    .ToList();
            }
            else
            {
                ViewBag.CalcedByUsers = _userManager.Users
                    .Select(user => new SelectListItem(user.FullName, user.Id.ToString())).ToList();
            }

            if (formReceptionAndMovementOfBulkProduct.CheckedByUser != null)
            {
                ViewBag.CheckedByUsers = _userManager.Users
                    .Select(user => new SelectListItem(user.FullName, user.Id.ToString(),
                        formReceptionAndMovementOfBulkProduct.CheckedByUser.Id == user.Id))
                    .ToList();
            }
            else
            {
                ViewBag.CheckedByUsers = _userManager.Users
                    .Select(user => new SelectListItem(user.FullName, user.Id.ToString()))
                    .ToList();
            }


            if (formReceptionAndMovementOfBulkProduct.ShiftMaster != null)
            {
                ViewBag.ShiftMasters = _userManager.Users
                    .Select(user => new SelectListItem(user.FullName, user.Id.ToString(),
                        formReceptionAndMovementOfBulkProduct.ShiftMaster.Id == user.Id))
                    .ToList();
            }
            else
            {
                ViewBag.ShiftMasters = _userManager.Users
                    .Select(user => new SelectListItem(user.FullName, user.Id.ToString()))
                    .ToList();
            }


            if (formReceptionAndMovementOfBulkProduct == null)
            {
                return NotFound();
            }
            return View(formReceptionAndMovementOfBulkProduct);
        }

        // POST: FormReceptionAndMovementOfBulkProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, FormReceptionAndMovementOfBulkProduct formReceptionAndMovementOfBulkProduct)
        {
            if (id != formReceptionAndMovementOfBulkProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formReceptionAndMovementOfBulkProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormReceptionAndMovementOfBulkProductExists(formReceptionAndMovementOfBulkProduct.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new { id = formReceptionAndMovementOfBulkProduct.Id});
            }
            return View(formReceptionAndMovementOfBulkProduct);
        }

        // GET: FormReceptionAndMovementOfBulkProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formReceptionAndMovementOfBulkProduct = await _context.FormReceptionAndMovementOfBulkProducts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formReceptionAndMovementOfBulkProduct == null)
            {
                return NotFound();
            }

            return View(formReceptionAndMovementOfBulkProduct);
        }

        // POST: FormReceptionAndMovementOfBulkProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formReceptionAndMovementOfBulkProduct = await _context.FormReceptionAndMovementOfBulkProducts.FindAsync(id);
            _context.FormReceptionAndMovementOfBulkProducts.Remove(formReceptionAndMovementOfBulkProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormReceptionAndMovementOfBulkProductExists(int id)
        {
            return _context.FormReceptionAndMovementOfBulkProducts.Any(e => e.Id == id);
        }
    }

    public class Response
    {
        public ResponseStatus Status { get; set; }
        public string ProtocolState { get; set; }
    }

    public enum ResponseStatus
    {
       error,
       ok
    }

}
