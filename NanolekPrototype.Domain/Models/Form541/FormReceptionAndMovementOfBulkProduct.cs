using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    /// <summary>
    /// Прием и движение балк-продукта (таблеток нерасфасованных)
    /// </summary>
    [Serializable()]
    public class FormReceptionAndMovementOfBulkProduct : PackagingProtocolForm
    {
        /// <summary>
        /// Тип
        /// </summary>
        [NotMapped]
        [DisplayName("Тип")]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.ReceptionAndMovementOfBulkProduct;
        /// <summary>
        /// Внутренний код материала
        /// </summary>
        [DisplayName("Внутренний код материала")]
        public int InternalCodeOfMaterial { get; set; }
        /// <summary>
        /// Спецификация
        /// </summary>
        [DisplayName("Спецификация")]
        public string Specification { get; set; }
        /// <summary>
        /// Расчет произвел (ФИО)
        /// </summary>
        [DisplayName("Расчет произвел (ФИО)")]
        [XmlIgnore]
        public User CalcedByUser { get; set; }
        public int? CalcedByUserId { get; set; }
        /// <summary>
        /// Расчет произвел (Дата)
        /// </summary>
        [DisplayName("Расчет произвел (Дата)")]
        public DateTime CalcedByUserDate { get; set; }
        /// <summary>
        /// Расчет проверил (ФИО)
        /// </summary>
        [DisplayName("Расчет проверил (ФИО)")]
        [XmlIgnore]
        public User CheckedByUser { get; set; }
        public int? CheckedByUserId { get;set; }
        /// <summary>
        /// Расчет проверил (Дата)
        /// </summary>
        [DisplayName("Расчет проверил (Дата)")]
        public DateTime CheckedByUserDate { get; set; }
        /// <summary>
        /// Дата
        /// </summary>

        //Группа «Приём балк-продукта (таблеток нерасфасованных)»:
        [DisplayName("Дата")]
        public DateTime Date { get; set; }
        /// <summary>
        /// Получено ПрП по документации, кг
        /// </summary>
        [DisplayName("Получено ПрП по документации, кг")]
        public int GetPRP { get; set; }
        /// <summary>
        /// Партия SAP
        /// </summary>
        [DisplayName("Партия SAP")]
        public string PartSAP { get; set; }
        /// <summary>
        /// Балк-продукт (ПрП) соответствуют показателям контроля
        /// </summary>
        [DisplayName("Балк-продукт (ПрП) соответствуют показателям контроля")]
        public bool IsCorrespondToControlIndicators { get; set; }
        /// <summary>
        /// Соответствие срока хранения ПрП
        /// </summary>
        [DisplayName("Соответствие срока хранения ПрП")]
        public bool IsCorrespondToShelfLife { get; set; }
        /// <summary>
        /// Мастер смены
        /// </summary>
        [DisplayName("Мастер смены")]
        [XmlIgnore]
        public User ShiftMaster { get; set; }
        public int? ShiftMasterId { get; set; }
        /// <summary>
        /// Таблица «Движение балк-продукта(таблеток нерасфасованных)
        /// </summary>

        //Таблица «Движение балк-продукта(таблеток нерасфасованных)»:
        [XmlArray("MovementOfBulkProducts")]
        [XmlArrayItem("MovementOfBulkProduct", typeof(TableMovementOfBulkProduct))]
        public List<TableMovementOfBulkProduct> MovementOfBulkProducts { get; set; }

        /// <summary>
        /// Вошло в состав ГП (в том числе отбор проб), уп.
        /// </summary>
        //Группа «Баланс по окончании серии»:
        [DisplayName("Вошло в состав ГП (в том числе отбор проб), уп.")]
        public int EntredIntoGPPackages { get; set; }
        /// <summary>
        /// Вошло в состав ГП (в том числе отбор проб), шт. блистеров
        /// </summary>
        [DisplayName("Вошло в состав ГП (в том числе отбор проб), шт. блистеров")]
        public int EntredIntoGPUnits { get; set; }
        /// <summary>
        /// Отходы балк-продукта (таблеток нерасфасованных), шт. блистеров
        /// </summary>
        [DisplayName("Отходы балк-продукта (таблеток нерасфасованных), шт. блистеров")]
        public int GarbageUnits { get; set; }
        /// <summary>
        /// Брак (по окончании первичной упаковки), шт. блистеров
        /// </summary>
        [DisplayName("Брак (по окончании первичной упаковки), шт. блистеров")]
        public int DefectFirstPackageUnits { get; set; }
        /// <summary>
        /// Отбор проб (герметичность), шт. блистеров
        /// </summary>
        [DisplayName("Отбор проб (герметичность), шт. блистеров")]
        public int SampleSelectionUnits { get; set; }
        /// <summary>
        /// Брак (по окончании вторичной упаковки), шт. блистеров
        /// </summary>
        [DisplayName("Брак (по окончании вторичной упаковки), шт. блистеров")]
        public int GarbageSecondPackageUnits { get; set; }


    }
}