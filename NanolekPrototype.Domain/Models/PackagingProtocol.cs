using System;
using System.Collections;
using System.Collections.Generic;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class PackagingProtocol
    {
        public long Id { get; set; }

        public Guid Guid { get; set; }
        public string SerialNumber { get; set; }
        public User ResponsibleUserOOK { get; set; }
        public string StorageConditions { get; set; }
        public double ShelfLife { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime SellBy { get; set; }
        public string PackageNumber { get; set; }
        public User ResponsibleUserTLF { get; set; }
        public string TradeName { get; set; }
        public string SpecificationGP { get; set; }
        public string InternalCodeGP { get; set; }
        public PackagingProtocolStatus PackagingProtocolStatus { get; set; }
        public string CancellationReason { get; set; }


        public ICollection<FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox> ForMarkingThermalTransferLabelOnCorrugatedBoxes { get; set; }
        public ICollection<FormCheckingCheckweighingSetting> FormCheckingCheckweighingSettings { get; set; }
        public ICollection<FormCheckingRejectionOfDefectiveTablet> FormCheckingRejectionOfDefectiveTablets { get; set; }
        public ICollection<FormControlOfPrimaryPackaging> FormControlOfPrimaryPackagings { get; set; }
        public ICollection<FormMaterialBalanceOfGPByLot> FormMaterialBalanceOfGpByLots { get; set; }
        public ICollection<FormReceptionAndMovementOfBulkProduct> FormReceptionAndMovementOfBulkProducts { get; set; }
        public ICollection<FormReceptionAndMovementOfPackingMaterial> FormReceptionAndMovementOfPackingMaterials { get; set; }
        public ICollection<FormSamplingFinishedProduct> FormSamplingFinishedProducts { get; set; }
        public ICollection<FormSettingUpTechnologicalEquipment> FormSettingUpTechnologicalEquipments { get; set; }
    }
}