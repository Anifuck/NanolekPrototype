using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using NanolekPrototype.Context;
using NanolekPrototype.EntityModels.Enums;
using NanolekPrototype.EntityModels.Models;

namespace NanolekPrototype.Services
{
    public class PackingProtocolService : IPackingProtocolService
    {
        private readonly ApplicationContext _context;
        private readonly UserManager<User> _userManager;

        public PackingProtocolService(ApplicationContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public void GenerateNewProtocol()
        {
            PackagingProtocol packagingProtocol = new PackagingProtocol()
            {
                Guid = Guid.NewGuid(),
                SerialNumber = new Random().Next().ToString(),
                ResponsibleUserOOK = _userManager.Users.First(),
                StorageConditions = "В сухом месте при температуре 20 градусов",
                ManufacturingDate = DateTime.Today.AddDays(-100),
                SellBy = DateTime.Today,
                ShelfLife = DateTime.Today.ToOADate() - DateTime.Today.AddDays(-100).ToOADate(),
                PackageNumber = "112214",
                ResponsibleUserTLF = _userManager.Users.First(),
                TradeName = "Доктор мом",
                SpecificationGP = "290220",
                InternalCodeGP = "114134",
                PackagingProtocolStatus = PackagingProtocolStatus.Cancelled,
                CancellationReason = "нет причин для отмены"
            };
            _context.PackagingProtocols.Add(packagingProtocol);
            _context.SaveChanges();
        }
    }
}