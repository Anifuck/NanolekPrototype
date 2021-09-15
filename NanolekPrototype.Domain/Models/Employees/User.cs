using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace NanolekPrototype.EntityModels.Models
{
    [Serializable]
    public class User : IdentityUser<int>
    {
        [DisplayName("Фио")]
        public string FullName { get; set; }
        [DisplayName("Должность")]
        public string Position { get; set; }
        public List<PackagingProtocol> OOK { get; set; }
        public List<PackagingProtocol> TLF { get; set; }

        public List<FormReceptionAndMovementOfBulkProduct> FormReceptionAndMovementOfBulkProductCalcers { get; set; }
        public List<FormReceptionAndMovementOfBulkProduct> FormReceptionAndMovementOfBulkProductCheckers { get; set; }
        public List<FormReceptionAndMovementOfBulkProduct> FormReceptionAndMovementOfBulkProductShiftMasters { get; set; }
        public List<FormReceptionAndMovementOfPackingMaterial> FormReceptionAndMovementOfPackingMaterialCalcers
        {
            get;
            set;
        }
        public List<FormReceptionAndMovementOfPackingMaterial> FormReceptionAndMovementOfPackingMaterialCheckers
        {
            get;
            set;
        }
        public List<FormReceptionAndMovementOfPackingMaterial> FormReceptionAndMovementOfPackingMaterialShiftMasters
        {
            get;
            set;
        }
        public List<TableReceptionOfMaterial> TableReceptionOfMaterialShiftMasters { get; set; }
        public List<TableSettingUpTechnologicalEquipment> TableSettingUpTechnologicalEquipmentServiceTechnicians { get; set; }
        public List<TableVerificationAction> TableVerificationActionTaskMasters { get; set; }
        public List<TablePackagingControl> TablePackagingControlTaskMasters { get; set; }
        public List<FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox> FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxTaskGivens { get; set; }
        public List<FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox> FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxTaskGots { get; set; }
        public List<TableCheckingProcedure> TableCheckingProcedureExecutors { get; set; }
        public List<FormSamplingFinishedProduct> FormSamplingFinishedProductShiftMasters { get; set; }
        public List<FormSamplingFinishedProduct> FormSamplingFinishedProductTaskMasters { get; set; }
        public List<TableProcedure> TableProcedureExecutors { get; set; }
        public List<TableProcedure> TableProcedureCheckers { get; set; }
        public List<TableSampleSelection> TableSampleSelectionEmployeeOKKs { get; set; }
        public List<FormMaterialBalanceOfGPByLot> FormMaterialBalanceOfGPByLotShiftMasters { get; set; }
        public List<FormMaterialBalanceOfGPByLot> FormMaterialBalanceOfGPByLotCalcedByUsers { get; set; }
        public List<FormMaterialBalanceOfGPByLot> FormMaterialBalanceOfGPByLotCheckedByUsers { get; set; }
        public List<FormMaterialBalanceOfGPByLot> FormMaterialBalanceOfGPByLotCheckedPUByUsers { get; set; }
        public List<FormMaterialBalanceOfGPByLot> FormMaterialBalanceOfGPByLotTaskMasters { get; set; }

    }
}