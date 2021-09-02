using System;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task GenerateReceptionAndMovementOfBulkProduct(PackagingProtocol packagingProtocol)
        {
            FormReceptionAndMovementOfBulkProduct formReceptionAndMovementOfBulkProduct = new FormReceptionAndMovementOfBulkProduct()
            {
                Guid = Guid.NewGuid(),
                IsActive = true,
                Status = FormStatus.InWork,
                PackagingProtocol = packagingProtocol,
            };
            


            TableMovementOfBulkProduct tableMovementOfBulkProduct = new TableMovementOfBulkProduct()
            {
                FormReceptionAndMovementOfBulkProduct = formReceptionAndMovementOfBulkProduct,
            };


            await _context.FormReceptionAndMovementOfBulkProducts.AddAsync(formReceptionAndMovementOfBulkProduct);
            await _context.MovementOfBulkProducts.AddAsync(tableMovementOfBulkProduct);
            await _context.SaveChangesAsync();

        }

        public async Task GenerateNewProtocol()
        {
            PackagingProtocol packagingProtocol = new PackagingProtocol()
            {
                Guid = Guid.NewGuid(),
                IsActive = true,
                SerialNumber = "000001" + new Random().Next().ToString(),
                ResponsibleUserOOK = _userManager.Users.First(),
                StorageConditions = "В сухом месте при температуре 20 градусов",
                ManufacturingDate = DateTime.Now.AddDays(-1),
                SellBy = DateTime.Now.AddDays(-1).AddYears(3),
                ShelfLife = DateTime.Now.AddDays(-1).AddYears(3).ToOADate() - DateTime.Now.AddDays(-1).ToOADate(),
                PackageNumber = "2158" + new Random().Next().ToString(),
                ResponsibleUserTLF = _userManager.Users.First(),
                TradeName = "Доктор мом" + new Random().Next(100).ToString(),
                SpecificationGP = new Random().Next().ToString(),
                InternalCodeGP = new Random().Next().ToString(),
                PackagingProtocolStatus = PackagingProtocolStatus.InWork,
                CancellationReason = "нет причин для отмены",
            };
            
            await _context.PackagingProtocols.AddAsync(packagingProtocol);
            await _context.SaveChangesAsync();
            await GenerateReceptionAndMovementOfBulkProduct(packagingProtocol);
        }
    }
}