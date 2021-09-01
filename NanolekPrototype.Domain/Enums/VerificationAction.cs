using System.ComponentModel;

namespace NanolekPrototype.EntityModels.Enums
{
    public enum VerificationAction
    {
        [Description("Камера блистерной машины настроена согласно СОП П02 02 032 «Подготовка к работе блистерной машины TR 200 на формат ПВХ /АЛЮ»")]
        first,
        [Description("Камера блистерной машины прошла проверку на отбраковку дефектных таблеток в соответствии с СОП П02 02-120 «Порядок первичной упаковки лекарственных препаратов по полному циклу на 1 и 2 упаковочных линиях»")]
        second,
        [Description("Первичную упаковку разрешаю")]
        third
    }
}