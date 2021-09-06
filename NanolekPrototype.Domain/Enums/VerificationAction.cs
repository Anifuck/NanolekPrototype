using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NanolekPrototype.EntityModels.Enums
{
    public enum VerificationAction
    {
        [Display(Name="Камера блистерной машины настроена согласно СОП П02 02 032 «Подготовка к работе блистерной машины TR 200 на формат ПВХ /АЛЮ»")]
        first,
        [Display(Name="Камера блистерной машины прошла проверку на отбраковку дефектных таблеток в соответствии с СОП П02 02-120 «Порядок первичной упаковки лекарственных препаратов по полному циклу на 1 и 2 упаковочных линиях»")]
        second,
        [Display(Name="Первичную упаковку разрешаю")]
        third
    }
}