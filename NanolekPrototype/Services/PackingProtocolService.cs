using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NanolekPrototype.Context;
using NanolekPrototype.Controllers;
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

        public async Task GenerateFormMaterialBalanceOfGPByLot(PackagingProtocol packagingProtocol)
        {
            FormMaterialBalanceOfGPByLot formMaterialBalanceOfGpByLot =
                new FormMaterialBalanceOfGPByLot()
                {
                    Guid = Guid.NewGuid(),
                    IsActive = true,
                    Status = FormStatus.InWork,
                    PackagingProtocol = packagingProtocol
                };

            await _context.AddAsync(formMaterialBalanceOfGpByLot);
            await _context.SaveChangesAsync();
        }

        public async Task GenerateFormSamplingFinishedProduct(PackagingProtocol packagingProtocol)
        {
            FormSamplingFinishedProduct formSamplingFinishedProduct =
                new FormSamplingFinishedProduct()
                {
                    Guid = Guid.NewGuid(),
                    IsActive = true,
                    Status = FormStatus.InWork,
                    PackagingProtocol = packagingProtocol
                };

            TableSampleSelection tableSampleSelection = new TableSampleSelection()
            {
                FormSamplingFinishedProduct = formSamplingFinishedProduct,
                IsActive = true,
            };

            await _context.AddAsync(formSamplingFinishedProduct);
            await _context.AddAsync(tableSampleSelection);

            foreach (var procedure in Enum.GetNames<Procedure>())
            {
                TableProcedure tableProcedure = new TableProcedure()
                {
                    FormSamplingFinishedProduct = formSamplingFinishedProduct,
                    IsActive = true,
                    Procedure = Enum.Parse<Procedure>(procedure)
                };
                await _context.AddAsync(tableProcedure);
            }

            await _context.SaveChangesAsync();

        }

        public async Task GenerateFormCheckingCheckweighingSetting(PackagingProtocol packagingProtocol)
        {
            FormCheckingCheckweighingSetting formCheckingCheckweighingSetting =
                new FormCheckingCheckweighingSetting()
                {
                    Guid = Guid.NewGuid(),
                    IsActive = true,
                    Status = FormStatus.InWork,
                    PackagingProtocol = packagingProtocol
                };

            TableCheckingProcedure tableCheckingProcedure = new TableCheckingProcedure()
            {
                FormCheckingCheckweighingSetting = formCheckingCheckweighingSetting,
                IsActive = true,
            };

            await _context.AddAsync(formCheckingCheckweighingSetting);
            await _context.AddAsync(tableCheckingProcedure);
            await _context.SaveChangesAsync();
        }

        public async Task GenerateFormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox(
            PackagingProtocol packagingProtocol)
        {
            FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox forMarkingThermalTransferLabelOnCorrugatedBox =
                new FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox()
                {
                    Guid = Guid.NewGuid(),
                    IsActive = true,
                    Status = FormStatus.InWork,
                    PackagingProtocol = packagingProtocol
                };

            await _context.AddAsync(forMarkingThermalTransferLabelOnCorrugatedBox);
            await _context.SaveChangesAsync();
        }


        public async Task GenerateFormControlOfPrimaryPackaging(PackagingProtocol packagingProtocol)
        {
            FormControlOfPrimaryPackaging formControlOfPrimaryPackaging =
                new FormControlOfPrimaryPackaging()
                {
                    Guid = Guid.NewGuid(),
                    IsActive = true,
                    Status = FormStatus.InWork,
                    PackagingProtocol = packagingProtocol
                };

            

            TablePackagingControl tablePackagingControl = new TablePackagingControl()
                {
                    FormControlOfPrimaryPackaging = formControlOfPrimaryPackaging,
                    IsActive = true,
                };

            await _context.AddAsync(formControlOfPrimaryPackaging);
            await _context.AddAsync(tablePackagingControl);
            await _context.SaveChangesAsync();
        }

        public async Task GenerateFormCheckingRejectionOfDefectiveTablet(PackagingProtocol packagingProtocol)
        {
            FormCheckingRejectionOfDefectiveTablet formCheckingRejectionOfDefectiveTablet =
                new FormCheckingRejectionOfDefectiveTablet()
                {
                    Guid = Guid.NewGuid(),
                    IsActive = true,
                    Status = FormStatus.InWork,
                    PackagingProtocol = packagingProtocol
                };

            await _context.AddAsync(formCheckingRejectionOfDefectiveTablet);

            foreach (var verificationAction in Enum.GetNames<VerificationAction>())
            {
                TableVerificationAction tableVerificationAction = new TableVerificationAction()
                {
                    FormCheckingRejectionOfDefectiveTablet = formCheckingRejectionOfDefectiveTablet,
                    IsActive = true,
                    Action = Enum.Parse<VerificationAction>(verificationAction)
                };

                await _context.AddAsync(tableVerificationAction);

            }

            await _context.SaveChangesAsync();

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
            var lastProtocol = await _context.PackagingProtocols.OrderBy(protocol=>protocol.Id).LastOrDefaultAsync();

            string serialNumber = (lastProtocol == null)
                ? "000001" + new Random().Next().ToString()
                : "00000" + (Int64.Parse(lastProtocol.SerialNumber) + 1).ToString();

            string packageNumber = (lastProtocol == null)
                ? "2158" + new Random().Next().ToString()
                : (Int64.Parse(lastProtocol.PackageNumber) + 1).ToString();

            var farmList = new List<string>()
            {
                "Аторвастатин",
                "Амлодипин",
                "Бисопролол"
            };

            var sellBy = DateTime.Now.AddDays(-1).AddYears(new Random().Next(1, 4));

            PackagingProtocol packagingProtocol = new PackagingProtocol()
            {
                Guid = Guid.NewGuid(),
                IsActive = true,
                SerialNumber = serialNumber,
                ResponsibleUserOOK = _userManager.Users.First(),
                StorageConditions = "В сухом месте при температуре 20 градусов",
                ManufacturingDate = DateTime.Now.AddDays(-1),
                SellBy = sellBy,
                ShelfLife = Math.Round(sellBy.ToOADate() - DateTime.Now.AddDays(-1).ToOADate()),
                PackageNumber = packageNumber,
                ResponsibleUserTLF = _userManager.Users.Skip(1).First(),
                TradeName = farmList[new Random().Next(0,3)],
                SpecificationGP = "СпГП-П03-03-008.3/ПЦ",
                InternalCodeGP = new Random().Next().ToString(),
                PackagingProtocolStatus = PackagingProtocolStatus.InWork,
                CancellationReason = "",
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
            await GenerateFormCheckingRejectionOfDefectiveTablet(packagingProtocol);
            await GenerateFormControlOfPrimaryPackaging(packagingProtocol);
            await GenerateFormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox(packagingProtocol);
            await GenerateFormCheckingCheckweighingSetting(packagingProtocol);
            await GenerateFormSamplingFinishedProduct(packagingProtocol);
            await GenerateFormMaterialBalanceOfGPByLot(packagingProtocol);
        }

        public async Task CheckProtocolStatus(int packagingProtocolId)
        {
            var packagingProtocol = await _context.PackagingProtocols
                .Include(p=>p.FormCheckingCheckweighingSettings)
                .Include(p=>p.FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxes)
                .Include(p=>p.FormControlOfPrimaryPackagings)
                .Include(p=>p.FormReceptionAndMovementOfPackingMaterials)
                .Include(p => p.FormSettingUpTechnologicalEquipments)
                .Include(p => p.FormReceptionAndMovementOfBulkProducts)
                .Include(p=>p.FormCheckingRejectionOfDefectiveTablets)
                .Include(p=>p.FormSamplingFinishedProducts)
                .Include(p=>p.FormMaterialBalanceOfGpByLots)
                .FirstAsync(p => p.Id == packagingProtocolId);


            if (packagingProtocol.FormReceptionAndMovementOfBulkProducts.First().Status == FormStatus.Approved 
                && packagingProtocol.FormReceptionAndMovementOfPackingMaterials.First().Status == FormStatus.Approved
                && packagingProtocol.FormSettingUpTechnologicalEquipments.First().Status == FormStatus.Approved
                && packagingProtocol.FormCheckingRejectionOfDefectiveTablets.First().Status == FormStatus.Approved
                && packagingProtocol.FormControlOfPrimaryPackagings.First().Status == FormStatus.Approved
                && packagingProtocol.FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxes.First().Status == FormStatus.Approved
                && packagingProtocol.FormCheckingCheckweighingSettings.First().Status == FormStatus.Approved
                && packagingProtocol.FormSamplingFinishedProducts.First().Status == FormStatus.Approved
                && packagingProtocol.FormMaterialBalanceOfGpByLots.First().Status == FormStatus.Approved)
                packagingProtocol.PackagingProtocolStatus = PackagingProtocolStatus.Completed;
            await _context.SaveChangesAsync();
        }

        public JsonResult AjaxResponse(PackagingProtocolForm form)
        {
            var type = typeof(FormStatus);
            var memberInfo = type.GetMember(form.Status.ToString());
            var attributes = memberInfo.First().GetCustomAttributes(typeof(DisplayAttribute), false);
            var description = ((DisplayAttribute)attributes.First()).Name;

            var response = new Response()
            {
                Status = ResponseStatus.ok,
                ProtocolState = description
            };

            return new JsonResult(response);
        }
    }
}