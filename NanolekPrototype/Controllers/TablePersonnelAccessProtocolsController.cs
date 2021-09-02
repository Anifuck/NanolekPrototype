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
    public class TablePersonnelAccessProtocolsController : Controller
    {
        private readonly ApplicationContext _context;

        public TablePersonnelAccessProtocolsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: TablePersonnelAccessProtocols
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersonnelAccessProtocols.ToListAsync());
        }

        // GET: TablePersonnelAccessProtocols/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tablePersonnelAccessProtocol = await _context.PersonnelAccessProtocols
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tablePersonnelAccessProtocol == null)
            {
                return NotFound();
            }

            return View(tablePersonnelAccessProtocol);
        }

        // GET: TablePersonnelAccessProtocols/Create
        public IActionResult Create(int protocolid)
        {
            ViewData["PackagingProtocolId"] = protocolid;
            return View();
        }

        // POST: TablePersonnelAccessProtocols/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TablePersonnelAccessProtocol tablePersonnelAccessProtocol)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tablePersonnelAccessProtocol);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tablePersonnelAccessProtocol);
        }

        // GET: TablePersonnelAccessProtocols/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tablePersonnelAccessProtocol = await _context.PersonnelAccessProtocols.FindAsync(id);
            if (tablePersonnelAccessProtocol == null)
            {
                return NotFound();
            }
            return View(tablePersonnelAccessProtocol);
        }

        // POST: TablePersonnelAccessProtocols/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IsActive,ProtocolNumber,ProtocolDate")] TablePersonnelAccessProtocol tablePersonnelAccessProtocol)
        {
            if (id != tablePersonnelAccessProtocol.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tablePersonnelAccessProtocol);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TablePersonnelAccessProtocolExists(tablePersonnelAccessProtocol.Id))
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
            return View(tablePersonnelAccessProtocol);
        }

        // GET: TablePersonnelAccessProtocols/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tablePersonnelAccessProtocol = await _context.PersonnelAccessProtocols
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tablePersonnelAccessProtocol == null)
            {
                return NotFound();
            }

            return View(tablePersonnelAccessProtocol);
        }

        // POST: TablePersonnelAccessProtocols/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tablePersonnelAccessProtocol = await _context.PersonnelAccessProtocols.FindAsync(id);
            _context.PersonnelAccessProtocols.Remove(tablePersonnelAccessProtocol);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TablePersonnelAccessProtocolExists(int id)
        {
            return _context.PersonnelAccessProtocols.Any(e => e.Id == id);
        }
    }
}
