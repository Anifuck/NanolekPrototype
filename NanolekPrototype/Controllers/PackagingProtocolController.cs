using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NanolekPrototype.Models;
using NanolekPrototype.ViewModels;

namespace NanolekPrototype.Controllers
{
    public class PackagingProtocolController : Controller
    {
        readonly ApplicationContext _context;
        readonly UserManager<User> _userManager;

        public PackagingProtocolController(ApplicationContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<ActionResult> Index() => View(await _context.PackagingProtocols.ToListAsync());

        public async Task<ActionResult> Edit(int id)
        {
            PackagingProtocol packagingProtocol =
                await _context.PackagingProtocols
                    .Where(pp => pp.Id == id)
                    .Include(pp => pp.ResponsibleUserOOK)
                    .Include(pp => pp.ResponsibleUserTLF)
                    .FirstAsync();

            EditPackagingProtocolViewModel editPackagingProtocolViewModel = new EditPackagingProtocolViewModel()
            {
                Id = packagingProtocol.Id,
                SerialNumber = packagingProtocol.SerialNumber,
                ResponsibleUserOOK = packagingProtocol.ResponsibleUserOOK,
                StorageConditions = packagingProtocol.StorageConditions,
                ManufacturingDate = packagingProtocol.ManufacturingDate,
                SellBy = packagingProtocol.SellBy,
                PackageNumber = packagingProtocol.PackageNumber,
                ResponsibleUserTLF = packagingProtocol.ResponsibleUserTLF,
                TradeName = packagingProtocol.TradeName,
                SpecificationGP = packagingProtocol.SpecificationGP,
                InternalCodeGP = packagingProtocol.InternalCodeGP,
                Status = packagingProtocol.Status,
                CancellationReason = packagingProtocol.CancellationReason
            };

            SelectList usersOOK = new SelectList(_userManager.Users.ToList(),
                "Id",
                "FullName",
                selectedValue: packagingProtocol.ResponsibleUserOOK.Id);

            SelectList usersTLF = new SelectList(_userManager.Users.ToList(),
                "Id",
                "FullName",
                selectedValue: packagingProtocol.ResponsibleUserTLF.Id);

            ViewBag.ResponsibleUserOOK = usersOOK;
            ViewBag.ResponsibleUserTLF = usersTLF;

            return View(editPackagingProtocolViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(EditPackagingProtocolViewModel editPPVM)
        {
            PackagingProtocol packagingProtocol = _context.PackagingProtocols.FirstOrDefault(pp => pp.Id == editPPVM.Id);

            packagingProtocol.SerialNumber = editPPVM.SerialNumber;
            packagingProtocol.ResponsibleUserOOK = await _userManager.FindByIdAsync(editPPVM.NewResponsibleUserOOKGuid);
            packagingProtocol.StorageConditions = editPPVM.StorageConditions;
            packagingProtocol.ShelfLife = editPPVM.SellBy.ToOADate() - editPPVM.ManufacturingDate.ToOADate();
            packagingProtocol.ManufacturingDate = editPPVM.ManufacturingDate;
            packagingProtocol.SellBy = editPPVM.SellBy;
            packagingProtocol.PackageNumber = editPPVM.PackageNumber;
            packagingProtocol.ResponsibleUserTLF = await _userManager.FindByIdAsync(editPPVM.NewResponsibleUserTLFGuid);
            packagingProtocol.TradeName = editPPVM.TradeName;
            packagingProtocol.SpecificationGP = editPPVM.SpecificationGP;
            packagingProtocol.InternalCodeGP = editPPVM.InternalCodeGP;
            packagingProtocol.Status = editPPVM.Status;
            packagingProtocol.CancellationReason = editPPVM.CancellationReason;
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            SelectList users = new SelectList(_userManager.Users.ToList(), "Id", "FullName");
            ViewBag.Users = users;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreatePackagingProtocolViewModel createPackagingProtocolViewModel)
        {
            try
            {
                PackagingProtocol packagingProtocol = new PackagingProtocol()
                {
                    Guid = Guid.NewGuid(),
                    SerialNumber = createPackagingProtocolViewModel.SerialNumber,
                    ResponsibleUserOOK =
                    await _userManager.FindByIdAsync(createPackagingProtocolViewModel.ResponsibleUserOOKGuid),
                    StorageConditions = createPackagingProtocolViewModel.StorageConditions,
                    ShelfLife = createPackagingProtocolViewModel.SellBy.ToOADate() - createPackagingProtocolViewModel.ManufacturingDate.ToOADate(),
                    ManufacturingDate = createPackagingProtocolViewModel.ManufacturingDate,
                    SellBy = createPackagingProtocolViewModel.SellBy,
                    PackageNumber = createPackagingProtocolViewModel.PackageNumber,
                    ResponsibleUserTLF = await _userManager.FindByIdAsync(createPackagingProtocolViewModel.ResponsibleUserTLFGuid),
                    TradeName = createPackagingProtocolViewModel.TradeName,
                    SpecificationGP = createPackagingProtocolViewModel.SpecificationGP,
                    InternalCodeGP = createPackagingProtocolViewModel.InternalCodeGP,
                    Status = createPackagingProtocolViewModel.Status,
                    CancellationReason = createPackagingProtocolViewModel.CancellationReason
                };

                await _context.PackagingProtocols.AddAsync(packagingProtocol);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public async Task<ActionResult> Delete(long id)
        {
            try
            {
                PackagingProtocol packagingProtocolForDelete = await _context.PackagingProtocols.FirstAsync(pp => pp.Id == id);
                _context.PackagingProtocols.Remove(packagingProtocolForDelete);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
