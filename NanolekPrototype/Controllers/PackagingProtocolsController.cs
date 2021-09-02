using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NanolekPrototype.Context;
using NanolekPrototype.EntityModels.Models;
using NanolekPrototype.Services;

namespace NanolekPrototype.Controllers
{
    public class PackagingProtocolsController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly IPackingProtocolService _packingProtocolService;

        public PackagingProtocolsController(ApplicationContext context, IPackingProtocolService packingProtocolService)
        {
            _context = context;
            _packingProtocolService = packingProtocolService;
        }

        // GET: PackagingProtocols
        public async Task<IActionResult> Index()
        {
            return View(await _context.PackagingProtocols.Where(pp=>pp.IsActive).OrderByDescending(pp=>pp.Id).ToListAsync());
        }

        // GET: PackagingProtocols/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packagingProtocol = await _context.PackagingProtocols
                .Include(m=>m.PersonnelAccessProtocols)
                .Include(m => m.ProductionPersonnels)
                .Include(m => m.PackagingProtocolForms)
                .Include(m => m.ResponsibleUserOOK)
                .Include(m => m.ResponsibleUserTLF)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (packagingProtocol == null)
            {
                return NotFound();
            }

            return View(packagingProtocol);
        }

        // GET: PackagingProtocols/Create
        public async Task<IActionResult> Create()
        {
            await _packingProtocolService.GenerateNewProtocol();
            return RedirectToAction(nameof(Index));
            //return View();
        }

        // POST: PackagingProtocols/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SerialNumber,StorageConditions,ShelfLife,ManufacturingDate,SellBy,PackageNumber,TradeName,SpecificationGP,InternalCodeGP,PackagingProtocolStatus,CancellationReason")] PackagingProtocol packagingProtocol)
        {
            if (ModelState.IsValid)
            {
                packagingProtocol.Guid = Guid.NewGuid();
                _context.Add(packagingProtocol);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(packagingProtocol);
        }

        // GET: PackagingProtocols/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packagingProtocol = await _context.PackagingProtocols.FindAsync(id);
            if (packagingProtocol == null)
            {
                return NotFound();
            }
            return View(packagingProtocol);
        }

        // POST: PackagingProtocols/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("Id,Guid,SerialNumber,StorageConditions,ShelfLife,ManufacturingDate,SellBy,PackageNumber,TradeName,SpecificationGP,InternalCodeGP,PackagingProtocolStatus,CancellationReason")] PackagingProtocol packagingProtocol)
        {
            if (id != packagingProtocol.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(packagingProtocol);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PackagingProtocolExists(packagingProtocol.Id))
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
            return View(packagingProtocol);
        }

        // GET: PackagingProtocols/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var packagingProtocol = await _context.PackagingProtocols
                .FirstOrDefaultAsync(m => m.Id == id);
            if (packagingProtocol == null)
            {
                return NotFound();
            }

            return View(packagingProtocol);
        }

        // POST: PackagingProtocols/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var packagingProtocol = await _context.PackagingProtocols.FindAsync(id);
            packagingProtocol.IsActive = false;
            //_context.PackagingProtocols.Remove(packagingProtocol);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PackagingProtocolExists(long id)
        {
            return _context.PackagingProtocols.Any(e => e.Id == id);
        }
    }
}
