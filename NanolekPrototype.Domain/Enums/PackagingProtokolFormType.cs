using System.ComponentModel;

namespace NanolekPrototype.EntityModels.Enums
{
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