using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NanolekPrototype.Context;
using NanolekPrototype.EntityModels.Enums;
using NanolekPrototype.EntityModels.Models;
using Action = NanolekPrototype.EntityModels.Enums.Action;

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

        public async Task GenerateSettingUpTechnologicalEquipment(PackagingProtocol packagingProtocol)
        {
            FormSettingUpTechnologicalEquipment  formSettingUpTechnologicalEquipment = new FormSettingUpTechnologicalEquipment()
            {
                Guid = Guid.NewGuid(),
                IsActive = true,
                Status = FormStatus.InWork,
                PackagingProtocol = packagingProtocol
            };
            await _context.AddAsync(formSettingUpTechnologicalEquipment);

            foreach (var act in Enum.GetNames<Action>())
            {
                TableSettingUpTechnologicalEquipment tableSettingUpTechnologicalEquipment =
                    new TableSettingUpTechnologicalEquipment()
                    {
                        FormSettingUpTechnologicalEquipment = formSettingUpTechnologicalEquipment,
                        IsActive = true,
                        Action = Enum.Parse<Action>(act)
                    };
                await _context.AddAsync(tableSettingUpTechnologicalEquipment);
            }
            await _context.SaveChangesAsync();
        }

        public async Task GenerateReceptionAndMovementOfPackingMaterial(PackagingProtocol packagingProtocol)
        {
            FormReceptionAndMovementOfPackingMaterial formReceptionAndMovementOfPackingMaterial =
                new FormReceptionAndMovementOfPackingMaterial()
                {
                    Guid = Guid.NewGuid(),
                    IsActive = true,
                    Status = FormStatus.InWork,
                    PackagingProtocol = packagingProtocol,
                };

            TableReceptionOfMaterial tableReceptionOfMaterial = new TableReceptionOfMaterial()
            {
                FormReceptionAndMovementOfPackingMaterial = formReceptionAndMovementOfPackingMaterial,
                IsActive = true,
            };

            await _context.AddAsync(formReceptionAndMovementOfPackingMaterial);
            await _context.AddAsync(tableReceptionOfMaterial);
            await _context.SaveChangesAsync();
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
                Executor = _userManager.Users.First(),
                GarbageKg = new Random().Next(100)
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
                ResponsibleUserTLF = _userManager.Users.Skip(1).First(),
                TradeName = "Доктор мом" + new Random().Next(100).ToString(),
                SpecificationGP = new Random().Next().ToString(),
                InternalCodeGP = new Random().Next().ToString(),
                PackagingProtocolStatus = PackagingProtocolStatus.InWork,
                CancellationReason = "нет причин для отмены",
            };

            TableProductionPersonnel tableProductionPersonnel = new TableProductionPersonnel()
            {
                IsActive = true,
                PackagingProtocol = packagingProtocol,
                FullName = _userManager.Users.First(),
                Position = _userManager.Users.First().Position
            };

            TablePersonnelAccessProtocol tablePersonnelAccessProtocol = new TablePersonnelAccessProtocol()
            {
                IsActive = false,
                PackagingProtocol = packagingProtocol,
                ProtocolDate = DateTime.Now,
                ProtocolNumber = packagingProtocol.SerialNumber
            };

            await _context.PackagingProtocols.AddAsync(packagingProtocol);
            await _context.ProductionPersonnels.AddAsync(tableProductionPersonnel);
            await _context.PersonnelAccessProtocols.AddRangeAsync(tablePersonnelAccessProtocol);

            await _context.SaveChangesAsync();

            await GenerateReceptionAndMovementOfBulkProduct(packagingProtocol);
            await GenerateReceptionAndMovementOfPackingMaterial(packagingProtocol);
            await GenerateSettingUpTechnologicalEquipment(packagingProtocol);
        }

        public async Task CheckProtocolStatus(int packagingProtocolId)
        {
            var packagingProtocol = await _context.PackagingProtocols.FirstAsync(p => p.Id == packagingProtocolId);
            if (packagingProtocol.FormReceptionAndMovementOfBulkProducts.First().Status == FormStatus.Approved)
                packagingProtocol.PackagingProtocolStatus = PackagingProtocolStatus.Completed;
            await _context.SaveChangesAsync();
        }
    }
}