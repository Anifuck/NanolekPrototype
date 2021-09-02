using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class PackagingProtocol
    {
        public long Id { get; set; }
        public bool IsActive { get; set; }

        /// <summary>
        /// GUID
        /// </summary>
        [DisplayName("GUID")]
        public Guid Guid { get; set; }
        /// <summary>
        /// Серия номер
        /// </summary>
        [DisplayName("Серия номер")]
        public string SerialNumber { get; set; }
        /// <summary>
        /// Ответственный работник ООК
        /// </summary>
        [DisplayName("Ответственный работник ООК")]
        public User ResponsibleUserOOK { get; set; }
        /// <summary>
        /// Условия хранения
        /// </summary>
        [DisplayName("Условия хранения")]
        public string StorageConditions { get; set; }
        /// <summary>
        /// Срок годности (дн.)
        /// </summary>
        [DisplayName("Срок годности (дн.)")]
        public double ShelfLife { get; set; }
        /// <summary>
        /// Дата изготовления
        /// </summary>
        [DisplayName("Дата изготовления")]
        public DateTime ManufacturingDate { get; set; }
        /// <summary>
        /// Годен до
        /// </summary>
        [DisplayName("Годен до")]
        public DateTime SellBy { get; set; }
        /// <summary>
        /// Номер упаковки
        /// </summary>
        [DisplayName("Номер упаковки")]
        public string PackageNumber { get; set; }
        /// <summary>
        /// Ответственный работник производства ТЛФ
        /// </summary>
        [DisplayName("Ответственный работник производства ТЛФ")]
        public User ResponsibleUserTLF { get; set; }
        /// <summary>
        /// Торговое наименование лекарственного препарата
        /// </summary>
        [DisplayName("Торговое наименование лекарственного препарата")]
        public string TradeName { get; set; }
        /// <summary>
        /// Спецификация ГП
        /// </summary>
        [DisplayName("Спецификация ГП")]
        public string SpecificationGP { get; set; }
        /// <summary>
        /// Внутренний код ГП
        /// </summary>
        [DisplayName("Внутренний код ГП")]
        public string InternalCodeGP { get; set; }
        /// <summary>
        /// Статус
        /// </summary>
        [DisplayName("Статус")]
        public PackagingProtocolStatus PackagingProtocolStatus { get; set; }
        /// <summary>
        /// Причина отмены
        /// </summary>
        [DisplayName("Причина отмены")]
        public string CancellationReason { get; set; }


        // Таблица «Персонал, задействованный в производстве»:
        public ICollection<TableProductionPersonnel> ProductionPersonnels { get; set; }

        // Таблица «Протоколы допуска персонала к работе»:
        public ICollection<TablePersonnelAccessProtocol> PersonnelAccessProtocols { get; set; }


        public ICollection<PackagingProtocolForm> PackagingProtocolForms { get; set; }
        //public ICollection<FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox> ForMarkingThermalTransferLabelOnCorrugatedBoxes { get; set; }
        //public ICollection<FormCheckingCheckweighingSetting> FormCheckingCheckweighingSettings { get; set; }
        //public ICollection<FormCheckingRejectionOfDefectiveTablet> FormCheckingRejectionOfDefectiveTablets { get; set; }
        //public ICollection<FormControlOfPrimaryPackaging> FormControlOfPrimaryPackagings { get; set; }
        //public ICollection<FormMaterialBalanceOfGPByLot> FormMaterialBalanceOfGpByLots { get; set; }
        //public ICollection<FormReceptionAndMovementOfBulkProduct> FormReceptionAndMovementOfBulkProducts { get; set; }
        //public ICollection<FormReceptionAndMovementOfPackingMaterial> FormReceptionAndMovementOfPackingMaterials { get; set; }
        //public ICollection<FormSamplingFinishedProduct> FormSamplingFinishedProducts { get; set; }
        //public ICollection<FormSettingUpTechnologicalEquipment> FormSettingUpTechnologicalEquipments { get; set; }
    }
}