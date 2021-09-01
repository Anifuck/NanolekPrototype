using System.ComponentModel;

namespace NanolekPrototype.EntityModels.Enums
{
    public enum FormStatus
    {
        [Description("В работе")]
        InWork,
        [Description("На контроле")]
        OnControl,
        [Description("Обработана")]
        Approved
    }
}