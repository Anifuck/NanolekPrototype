using System;
using System.Collections;
using System.Collections.Generic;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class PackagingProtocol
    {
        public long Id { get; set; }

        /// <summary>
        /// GUID
        /// </summary>
        public Guid Guid { get; set; }
        /// <summary>
        /// Серия номер
        /// </summary>
        public string SerialNumber { get; set; }
        /// <summary>
        /// Ответственный работник ООК
        /// </summary>
        public User ResponsibleUserOOK { get; set; }
        /// <summary>
        /// Условия хранения
        /// </summary>
        public string StorageConditions { get; set; }
        /// <summary>
        /// Срок годности (дн.)
        /// </summary>
        public double ShelfLife { get; set; }
        /// <summary>
        /// Дата изготовления
        /// </summary>
        public DateTime ManufacturingDate { get; set; }
        /// <summary>
        /// Годен до
        /// </summary>
        public DateTime SellBy { get; set; }
        /// <summary>
        /// Номер упаковки
        /// </summary>
        public string PackageNumber { get; set; }
        /// <summary>
        /// Ответственный работник производства ТЛФ
        /// </summary>
        public User ResponsibleUserTLF { get; set; }
        /// <summary>
        /// Торговое наименование лекарственного препарата
        /// </summary>
        public string TradeName { get; set; }
        /// <summary>
        /// Спецификация ГП
        /// </summary>
        public string SpecificationGP { get; set; }
        /// <summary>
        /// Внутренний код ГП
        /// </summary>
        public string InternalCodeGP { get; set; }
        /// <summary>
        /// Статус
        /// </summary>
        public PackagingProtocolStatus PackagingProtocolStatus { get; set; }
        /// <summary>
        /// Причина отмены
        /// </summary>
        public string CancellationReason { get; set; }


        // Таблица «Персонал, задействованный в производстве»:
        public ICollection<ProductionPersonnel> ProductionPersonnels { get; set; }

        // Таблица «Протоколы допуска персонала к работе»:
        public ICollection<PersonnelAccessProtocol> PersonnelAccessProtocols { get; set; }


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