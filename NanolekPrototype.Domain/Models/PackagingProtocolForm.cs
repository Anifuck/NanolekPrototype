using System;
using System.ComponentModel;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class PackagingProtocolForm
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }



        public Guid Guid { get; set; }
        public PackagingProtokolFormType Type { get; set; }
        public FormStatus Status { get; set; }
        public PackagingProtocol PackagingProtocol { get; set; }
        public string FormRequisitesJson { get; set; }
        public string Note { get; set; }
    }

    public enum PackagingProtokolFormType
    {
        [Description("Прием и движение балк-продукта (таблеток нерасфасованных)")]
        ReceptionAndMovementOfBulkProduct,
        [Description("Прием и движение упаковочных материалов – Фольга")]
        ReceptionAndMovementOfPackingMaterial,
        [Description("Настройка технологического оборудования")]
        SettingUpTechnologicalEquipment,
        [Description("Проверка отбраковки дефектных таблеток камерой блистерной машины")]
        CheckingRejectionOfDefectiveTablet,
        [Description("Контроль первичной упаковки")]
        ControlOfPrimaryPackaging,
        [Description("Задание на маркировку этикетки термотрансферной на гофрокороб")]
        AssignmentForMarkingThermalTransferLabelOnCorrugatedBox,
        [Description("Проверка настройки контрольных весов")]
        CheckingCheckweighingSetting,
        [Description("Отбор проб готового продукта")]
        SamplingFinishedProduct,
        [Description("Материальный баланс ГП по серии")]
        MaterialBalanceOfGPByLot

    }
}