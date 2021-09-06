using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace NanolekPrototype.EntityModels.Enums
{
    public enum PacksInCorrugatedBox
    {
        [Display(Name="80")]
        Eighty,
        [Display(Name="50")]
        Fifty
    }
}