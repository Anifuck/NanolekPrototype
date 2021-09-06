﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NanolekPrototype.EntityModels.Enums
{
    public enum Action
    {
        [Display(Name="Проверить правильность намотки фольги. Намотка фольги соответствует")]
        first,
        [Display(Name="Настроить блистерную машину согласно СОП-П02-02-032 «Подготовка к работе блистерной машины TR 200 на формат ПВХ/АЛЮ»")]
        second,
        [Display(Name="Настроить блистерную машину согласно заданию на настройку блистерной машины")]
        third,
        [Display(Name="Настроить узел маркировки блистерной машины согласно СОП П02 02 002 «Порядок работы на блистерной машине TR 200»")]
        fourth,
        [Display(Name="Установить значение переменныx данных согласно заданию на установку переменных данных на блистер")]
        fiveth,
        [Display(Name="Провести проверку узла контроля наполнения")]
        sixth,
        [Display(Name="Провести пробную маркировку на пустых блистерах")]
        seventh,
        [Display(Name="Записать установленное значение температуры формования ячеек, ºС")]
        eighth,
        [Display(Name="Записать установленное значение температуры спайки блистера, ºС")]
        nineth,
        [Display(Name="Записать установленную скорость блистерования, бл./мин")]
        tenth,
        [Display(Name="Предъявить образец блистера без таблеток с нанесенной переменной информацией бригадиру")]
        eleventh

    }
}