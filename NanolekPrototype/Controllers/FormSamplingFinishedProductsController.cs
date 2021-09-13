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
    public class FormSamplingFinishedProductsController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly UserManager<User> _userManager;
        private readonly IPackingProtocolService _packingProtocolService;

        public FormSamplingFinishedProductsController(ApplicationContext context, UserManager<User> userManager, IPackingProtocolService packingProtocolService)
        {
            _context = context;
            _userManager = userManager;
            _packingProtocolService = packingProtocolService;
        }

        public async Task<JsonResult> ApproveForm(int? id)
        {
            var form = await _context.FormSamplingFinishedProducts
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

        public async Task<IActionResult> SendOnControlForm(int? id)
        {
            var form = await _context.FormSamplingFinishedProducts
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
        public async Task<IActionResult> SendOnRevisionForm(int? id, FormSamplingFinishedProduct formSamplingFinishedProduct)
        {
            var form = await _context.FormSamplingFinishedProducts
                .Include(form => form.PackagingProtocol)
                .FirstOrDefaultAsync(form => form.Id == id);
            form.Status = FormStatus.InWork;
            form.Note = formSamplingFinishedProduct.Note;
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "PackagingProtocols", new { id = form.PackagingProtocol.Id });
        }

        // GET: FormSamplingFinishedProducts
        public async Task<IActionResult> Index()
        {
            var applicationContext = _context.FormSamplingFinishedProducts.Include(f => f.ShiftMaster).Include(f => f.TaskMaster);
            return View(await applicationContext.ToListAsync());
        }

        // GET: FormSamplingFinishedProducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formSamplingFinishedProduct = await _context.FormSamplingFinishedProducts
                .Include(f=>f.PackagingProtocol)
                .Include(f=>f.TableProcedures)
                .ThenInclude(t=>t.Checker)
                .Include(f => f.TableProcedures)
                .ThenInclude(t => t.Executor)
                .Include(f=>f.SampleSelections)
                .ThenInclude(t=>t.EmployeeOKK)
                .Include(f => f.ShiftMaster)
                .Include(f => f.TaskMaster)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formSamplingFinishedProduct == null)
            {
                return NotFound();
            }

            return View(formSamplingFinishedProduct);
        }

        // GET: FormSamplingFinishedProducts/Create
        public IActionResult Create()
        {
            ViewData["ShiftMasterId"] = new SelectList(_context.Users, "Id", "Id");
            ViewData["TaskMasterId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: FormSamplingFinishedProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NotificationNUmber,NotificationDate,ShiftMasterId,ProtocolNumber,Observations,TaskMasterId,Date,Id,IsActive,Guid,Status,Note")] FormSamplingFinishedProduct formSamplingFinishedProduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(formSamplingFinishedProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ShiftMasterId"] = new SelectList(_context.Users, "Id", "Id", formSamplingFinishedProduct.ShiftMasterId);
            ViewData["TaskMasterId"] = new SelectList(_context.Users, "Id", "Id", formSamplingFinishedProduct.TaskMasterId);
            return View(formSamplingFinishedProduct);
        }

        // GET: FormSamplingFinishedProducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formSamplingFinishedProduct = await _context.FormSamplingFinishedProducts.FindAsync(id);
            if (formSamplingFinishedProduct == null)
            {
                return NotFound();
            }
            ViewData["ShiftMasterId"] = new SelectList(_context.Users, "Id", "FullName", formSamplingFinishedProduct.ShiftMasterId);
            ViewData["TaskMasterId"] = new SelectList(_context.Users, "Id", "FullName", formSamplingFinishedProduct.TaskMasterId);
            return View(formSamplingFinishedProduct);
        }

        // POST: FormSamplingFinishedProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, FormSamplingFinishedProduct formSamplingFinishedProduct)
        {
            if (id != formSamplingFinishedProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(formSamplingFinishedProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FormSamplingFinishedProductExists(formSamplingFinishedProduct.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "FormSamplingFinishedProducts", new {id = formSamplingFinishedProduct.Id});
            }
            ViewData["ShiftMasterId"] = new SelectList(_context.Users, "Id", "FullName", formSamplingFinishedProduct.ShiftMasterId);
            ViewData["TaskMasterId"] = new SelectList(_context.Users, "Id", "FullName", formSamplingFinishedProduct.TaskMasterId);
            return View(formSamplingFinishedProduct);
        }

        // GET: FormSamplingFinishedProducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var formSamplingFinishedProduct = await _context.FormSamplingFinishedProducts
                .Include(f => f.ShiftMaster)
                .Include(f => f.TaskMaster)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (formSamplingFinishedProduct == null)
            {
                return NotFound();
            }

            return View(formSamplingFinishedProduct);
        }

        // POST: FormSamplingFinishedProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var formSamplingFinishedProduct = await _context.FormSamplingFinishedProducts.FindAsync(id);
            _context.FormSamplingFinishedProducts.Remove(formSamplingFinishedProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FormSamplingFinishedProductExists(int id)
        {
            return _context.FormSamplingFinishedProducts.Any(e => e.Id == id);
        }
    }
}
