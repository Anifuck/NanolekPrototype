using System.ComponentModel;

namespace NanolekPrototype.EntityModels.Enums
{
    public enum PackagingProtocolStatus
    {
        [Description("В работе")]
        InWork,
        [Description("Исполнитель технологического процесса")]
        Completed,
        [Description("Отменен")]
        Cancelled,
    }
}