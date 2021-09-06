using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NanolekPrototype.EntityModels.Enums
{
    public enum PackagingProtokolFormType
    {
        [Display(Name="Прием и движение балк-продукта (таблеток нерасфасованных)")]
        ReceptionAndMovementOfBulkProduct,
        [Display(Name="Прием и движение упаковочных материалов – Фольга")]
        ReceptionAndMovementOfPackingMaterial,
        [Display(Name="Настройка технологического оборудования")]
        SettingUpTechnologicalEquipment,
        [Display(Name="Проверка отбраковки дефектных таблеток камерой блистерной машины")]
        CheckingRejectionOfDefectiveTablet,
        [Display(Name="Контроль первичной упаковки")]
        ControlOfPrimaryPackaging,
        [Display(Name="Задание на маркировку этикетки термотрансферной на гофрокороб")]
        AssignmentForMarkingThermalTransferLabelOnCorrugatedBox,
        [Display(Name="Проверка настройки контрольных весов")]
        CheckingCheckweighingSetting,
        [Display(Name="Отбор проб готового продукта")]
        SamplingFinishedProduct,
        [Display(Name="Материальный баланс ГП по серии")]
        MaterialBalanceOfGPByLot

    }
}