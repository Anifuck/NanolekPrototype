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
                CancellationReason = "нет причин для отмены",
            };
            
            await _context.PackagingProtocols.AddAsync(packagingProtocol);
            await _context.SaveChangesAsync();
            await GenerateReceptionAndMovementOfBulkProduct(packagingProtocol);
        }
    }
}