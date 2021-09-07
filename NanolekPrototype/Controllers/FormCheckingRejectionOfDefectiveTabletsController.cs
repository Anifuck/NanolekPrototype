using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NanolekPrototype.Context;
using NanolekPrototype.EntityModels.Models;

namespace NanolekPrototype.Controllers
{
    public class FormCheckingRejectionOfDefectiveTabletsController : Controller
    {
        private readonly ApplicationContext _context;

        public FormCheckingRejectionOfDefectiveTabletsController(ApplicationContext context)
        {
            _context = context;
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
