using System.ComponentModel;

namespace NanolekPrototype.EntityModels.Enums
{
    public enum ProductionPersonnelRole
    {
        [Description("Исполнитель технологического процесса")]
        Executors,
        [Description("Контроль и проверка")]
        Checkers
    }
}