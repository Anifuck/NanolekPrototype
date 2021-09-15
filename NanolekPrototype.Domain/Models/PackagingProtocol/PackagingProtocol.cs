using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    [Serializable()]
    public class PackagingProtocol
    {
        [XmlElement("Id")]
        public int Id { get; set; }
        [XmlElement("IsActive")]
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
        [XmlIgnore]
        public User ResponsibleUserOOK { get; set; }
        public int ResponsibleUserOOKId { get; set; }
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
        [XmlIgnore]
        public User ResponsibleUserTLF { get; set; }
        public int ResponsibleUserTLFId { get; set; }
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
        [XmlArray("ProductionPersonnels")]
        [XmlArrayItem("ProductionPersonnel",typeof(TableProductionPersonnel))]
        public List<TableProductionPersonnel> ProductionPersonnels { get; set; }

        // Таблица «Протоколы допуска персонала к работе»:
        [XmlArray("PersonnelAccessProtocols")]
        [XmlArrayItem("PersonnelAccessProtocol", typeof(TablePersonnelAccessProtocol))]
        public List<TablePersonnelAccessProtocol> PersonnelAccessProtocols { get; set; }


        //public List<PackagingProtocolForm> PackagingProtocolForms { get; set; }
        [XmlArray("FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxes")]
        [XmlArrayItem("FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox", typeof(FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox))]
        public List<FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox> FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBoxes { get; set; }
        [XmlArray("FormCheckingCheckweighingSettings")]
        [XmlArrayItem("FormCheckingCheckweighingSetting", typeof(FormCheckingCheckweighingSetting))]
        public List<FormCheckingCheckweighingSetting> FormCheckingCheckweighingSettings { get; set; }
        [XmlArray("FormCheckingRejectionOfDefectiveTablets")]
        [XmlArrayItem("FormCheckingRejectionOfDefectiveTablet", typeof(FormCheckingRejectionOfDefectiveTablet))]
        public List<FormCheckingRejectionOfDefectiveTablet> FormCheckingRejectionOfDefectiveTablets { get; set; }
        [XmlArray("FormControlOfPrimaryPackagings")]
        [XmlArrayItem("FormControlOfPrimaryPackaging", typeof(FormControlOfPrimaryPackaging))]
        public List<FormControlOfPrimaryPackaging> FormControlOfPrimaryPackagings { get; set; }
        [XmlArray("FormMaterialBalanceOfGpByLots")]
        [XmlArrayItem("FormMaterialBalanceOfGpByLot", typeof(FormMaterialBalanceOfGPByLot))]
        public List<FormMaterialBalanceOfGPByLot> FormMaterialBalanceOfGpByLots { get; set; }
        [XmlArray("FormReceptionAndMovementOfBulkProducts")]
        [XmlArrayItem("FormReceptionAndMovementOfBulkProduct", typeof(FormReceptionAndMovementOfBulkProduct))]
        public List<FormReceptionAndMovementOfBulkProduct> FormReceptionAndMovementOfBulkProducts { get; set; }
        [XmlArray("FormReceptionAndMovementOfPackingMaterials")]
        [XmlArrayItem("FormReceptionAndMovementOfPackingMaterial", typeof(FormReceptionAndMovementOfPackingMaterial))]
        public List<FormReceptionAndMovementOfPackingMaterial> FormReceptionAndMovementOfPackingMaterials { get; set; }
        [XmlArray("FormSamplingFinishedProducts")]
        [XmlArrayItem("FormSamplingFinishedProduct", typeof(FormSamplingFinishedProduct))]
        public List<FormSamplingFinishedProduct> FormSamplingFinishedProducts { get; set; }
        [XmlArray("FormSettingUpTechnologicalEquipments")]
        [XmlArrayItem("FormSettingUpTechnologicalEquipment", typeof(FormSettingUpTechnologicalEquipment))]
        public List<FormSettingUpTechnologicalEquipment> FormSettingUpTechnologicalEquipments { get; set; }
    }
}