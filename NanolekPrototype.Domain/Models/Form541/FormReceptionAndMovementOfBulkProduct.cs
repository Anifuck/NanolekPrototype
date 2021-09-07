using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormReceptionAndMovementOfBulkProduct : PackagingProtocolForm
    {
        [NotMapped]
        [DisplayName("Тип")]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.ReceptionAndMovementOfBulkProduct;

        [DisplayName("Внутренний код материала")]
        public int InternalCodeOfMaterial { get; set; }
        [DisplayName("Спецификация")]
        public string Specification { get; set; }
        [DisplayName("Расчет произвел (ФИО)")]
        public User CalcedByUser { get; set; }
        public int? CalcedByUserId { get; set; }
        [DisplayName("Расчет произвел (Дата)")]
        public DateTime CalcedByUserDate { get; set; }
        [DisplayName("Расчет проверил (ФИО)")]
        public User CheckedByUser { get; set; }
        public int? CheckedByUserId { get;set; }
        [DisplayName("Расчет проверил (Дата)")]
        public DateTime CheckedByUserDate { get; set; }

        //Группа «Приём балк-продукта (таблеток нерасфасованных)»:
        [DisplayName("Дата")]
        public DateTime Date { get; set; }
        [DisplayName("Получено ПрП по документации, кг")]
        public int GetPRP { get; set; }
        [DisplayName("Партия SAP")]
        public string PartSAP { get; set; }
        [DisplayName("Балк-продукт (ПрП) соответствуют показателям контроля")]
        public bool IsCorrespondToControlIndicators { get; set; }
        [DisplayName("Соответствие срока хранения ПрП")]
        public bool IsCorrespondToShelfLife { get; set; }
        [DisplayName("Мастер смены")]
        public User ShiftMaster { get; set; }
        public int? ShiftMasterId { get; set; }

        //Таблица «Движение балк-продукта(таблеток нерасфасованных)»:
        public ICollection<TableMovementOfBulkProduct> MovementOfBulkProducts { get; set; }


        //Группа «Баланс по окончании серии»:
        [DisplayName("Вошло в состав ГП (в том числе отбор проб), уп.")]
        public int EntredIntoGPPackages { get; set; }
        [DisplayName("Вошло в состав ГП (в том числе отбор проб), шт. блистеров")]
        public int EntredIntoGPUnits { get; set; }
        [DisplayName("Отходы балк-продукта (таблеток нерасфасованных), шт. блистеров")]
        public int GarbageUnits { get; set; }
        [DisplayName("Брак (по окончании первичной упаковки), шт. блистеров")]
        public int DefectFirstPackageUnits { get; set; }
        [DisplayName("Отбор проб (герметичность), шт. блистеров")]
        public int SampleSelectionUnits { get; set; }
        [DisplayName("Брак (по окончании вторичной упаковки), шт. блистеров")]
        public int GarbageSecondPackageUnits { get; set; }


    }
}