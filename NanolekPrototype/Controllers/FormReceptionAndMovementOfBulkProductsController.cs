using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NanolekPrototype.Context;
using NanolekPrototype.EntityModels.Enums;
using NanolekPrototype.EntityModels.Models;

namespace NanolekPrototype.Controllers
{
    public class FormReceptionAndMovementOfBulkProductsController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly UserManager<User> _userManager;

        public FormReceptionAndMovementOfBulkProductsController(ApplicationContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> ApproveForm(int? id)
        {
           var form =  await _context.FormReceptionAndMovementOfBulkProducts.FirstOrDefaultAsync(form => form.Id == id);
           var user = await _userManager.FindByNameAsync(User.Identity.Name);

           form.Status = FormStatus.Approved;
           form.CheckedByUserDate = DateTime.Now;
           form.CheckedByUser = user;
           form.CalcedByUserDate = DateTime.Now;
           form.CalcedByUser = user;

            await _context.SaveChangesAsync();
           return RedirectToAction("Details", "PackagingProtocols", new {id=id});
        }

        public async Task<IActionResult> SendOnControlForm(int? id)
        {
            var form = await _context.FormReceptionAndMovementOfBulkProducts.FirstOrDefaultAsync(form => form.Id == id);
            form.Status = FormStatus.OnControl;
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "PackagingProtocols", new { id = id });
        }

        [HttpGet]
        public async Task<IActionResult> SendOnRevisionForm(int? id)
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendOnRevisionForm(int? id, FormReceptionAndMovementOfBulkProduct formReceptionAndMovementOfBulkProduct)
        {
            var form = await _context.FormReceptionAndMovementOfBulkProducts.FirstOrDefaultAsync(form => form.Id == id);
            form.Status = FormStatus.InWork;
            form.Note = formReceptionAndMovementOfBulkProduct.Note;
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "PackagingProtocols", new { id = id });
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
        public async Task<IActionResult> Create([Bind("Type,InternalCodeOfMaterial,Specification,CalcedByUserDate,CheckedByUserDate,Date,GetPRP,PartSAP,IsCorrespondToControlIndicators,IsCorrespondToShelfLife,EntredIntoGPPackages,EntredIntoGPUnits,GarbageUnits,DefectFirstPackageUnits,SampleSelectionUnits,GarbageSecondPackageUnits,Id,IsActive,Guid,Status,Note")] FormReceptionAndMovementOfBulkProduct formReceptionAndMovementOfBulkProduct)
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
                .FirstOrDefaultAsync(m => m.Id == id);
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
                return RedirectToAction(nameof(Index));
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
}
