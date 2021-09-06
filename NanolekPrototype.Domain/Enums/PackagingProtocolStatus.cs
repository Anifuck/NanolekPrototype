using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NanolekPrototype.EntityModels.Enums
{
    public enum PackagingProtocolStatus
    {
       // [Display(Name="В работе")]
        [Display(Name="В работе")]
        InWork,
        //[Display(Name="Исполнитель технологического процесса")]
        [Display(Name = "Исполнен")]
        Completed,
        //[Display(Name="Отменен")]
        [Display(Name = "Отменен")]
        Cancelled,
    }
}