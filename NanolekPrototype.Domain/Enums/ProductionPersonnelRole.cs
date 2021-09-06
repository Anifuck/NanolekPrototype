using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NanolekPrototype.EntityModels.Enums
{
    public enum ProductionPersonnelRole
    {
        [Display(Name="Исполнитель технологического процесса")]
        Executors,
        [Display(Name="Контроль и проверка")]
        Checkers
    }
}