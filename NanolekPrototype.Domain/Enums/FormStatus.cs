using System.ComponentModel;

namespace NanolekPrototype.EntityModels.Enums
{
    public enum FormStatus
    {
        [Display(Name="В работе")]
        InWork,
        [Display(Name="На контроле")]
        OnControl,
        [Display(Name="Обработана")]
        Approved
    }
}