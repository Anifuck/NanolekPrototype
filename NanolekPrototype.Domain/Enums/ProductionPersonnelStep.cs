using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NanolekPrototype.EntityModels.Enums
{
    public enum ProductionPersonnelStep
    {
        [Display(Name="Первичная упаковка")]
        PrimaryPack,
        [Display(Name="Вторичная упаковка")]
        SecondaryPack
    }
}