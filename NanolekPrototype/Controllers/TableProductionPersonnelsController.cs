using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NanolekPrototype.Context;
using NanolekPrototype.EntityModels.Models;

namespace NanolekPrototype.Controllers
{
    public class TableProductionPersonnelsController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly UserManager<User> _userManager;

        public TableProductionPersonnelsController(ApplicationContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

        // GET: TableProductionPersonnels
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductionPersonnels.ToListAsync());
        }

        // GET: TableProductionPersonnels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableProductionPersonnel = await _context.ProductionPersonnels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableProductionPersonnel == null)
            {
                return NotFound();
            }

            return View(tableProductionPersonnel);
        }

        // GET: TableProductionPersonnels/Create
        public IActionResult Create(int protocolid)
        {
            ViewData["PackagingProtocolId"] = protocolid;
            ViewBag.FullNames = _userManager.Users
                .Select(user => new SelectListItem(user.FullName, user.Id.ToString()));
            return View();
        }

        // POST: TableProductionPersonnels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TableProductionPersonnel tableProductionPersonnel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(tableProductionPersonnel.FullNameId.ToString());
                tableProductionPersonnel.FullName = user;
                tableProductionPersonnel.Position = user.Position;
                _context.Add(tableProductionPersonnel);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "PackagingProtocols", new { id = tableProductionPersonnel.PackagingProtocolId });
            }
            return View(tableProductionPersonnel);
        }

        // GET: TableProductionPersonnels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableProductionPersonnel =
                await _context.ProductionPersonnels
                    .Include(m => m.PackagingProtocol)
                    .Where(m => m.Id == id)
                    .FirstAsync();

            if (tableProductionPersonnel == null)
            {
                return NotFound();
            }
            return View(tableProductionPersonnel);
        }

        // POST: TableProductionPersonnels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TableProductionPersonnel tableProductionPersonnel)
        {
            if (id != tableProductionPersonnel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tableProductionPersonnel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TableProductionPersonnelExists(tableProductionPersonnel.Id))
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
            return View(tableProductionPersonnel);
        }

        // GET: TableProductionPersonnels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tableProductionPersonnel = await _context.ProductionPersonnels
                .Include(m=>m.PackagingProtocol)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableProductionPersonnel == null)
            {
                return NotFound();
            }

            return View(tableProductionPersonnel);
        }

        // POST: TableProductionPersonnels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tableProductionPersonnel = await _context.ProductionPersonnels.FindAsync(id);
            _context.ProductionPersonnels.Remove(tableProductionPersonnel);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "PackagingProtocols",
                new {id = tableProductionPersonnel.PackagingProtocolId});

            //return RedirectToAction(nameof(Index));
        }

        private bool TableProductionPersonnelExists(int id)
        {
            return _context.ProductionPersonnels.Any(e => e.Id == id);
        }
    }
}
