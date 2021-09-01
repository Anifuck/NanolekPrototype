using System.ComponentModel;

namespace NanolekPrototype.EntityModels.Enums
{
    public enum ProductionPersonnelStep
    {
        [Description("Первичная упаковка")]
        PrimaryPack,
        [Description("Вторичная упаковка")]
        SecondaryPack
    }
}