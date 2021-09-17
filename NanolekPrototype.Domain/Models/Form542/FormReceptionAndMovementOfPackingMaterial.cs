using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    /// <summary>
    /// Прием и движение упаковочных материалов – Фольга
    /// </summary>
    [Serializable()]
    public class FormReceptionAndMovementOfPackingMaterial : PackagingProtocolForm
    {
        /// <summary>
        /// Тип
        /// </summary>
        [NotMapped]
        [DisplayName("Тип")]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.ReceptionAndMovementOfPackingMaterial;

        //Группа «Основное»
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
        public int? CheckedByUserId { get; set; }
        /// <summary>
        /// Расчет проверил (Дата)
        /// </summary>
        [DisplayName("Расчет проверил (Дата)")]
        public DateTime CheckedByUserDate { get; set; }


        //Таблица «Приём материала»
        /// <summary>
        /// Таблица «Приём материала»
        /// </summary>
        [XmlArray("ReceptionOfMaterials")]
        [XmlArrayItem("ReceptionOfMaterial", typeof(TableReceptionOfMaterial))]
        public List<TableReceptionOfMaterial> ReceptionOfMaterials { get; set; }

        //Группа «Баланс по окончании серии»:
        /// <summary>
        /// Израсходовано на серию, кг
        /// </summary>
        [DisplayName("Израсходовано на серию, кг")]
        public int SpentOnBatch { get; set; }
        /// <summary>
        /// Остаток материала, кг
        /// </summary>
        [DisplayName("Остаток материала, кг")]
        public int RemainingMaterial { get; set; }
        /// <summary>
        /// Передано на склад
        /// </summary>
        [DisplayName("Передано на склад")]
        public bool IsSentToStorage { get; set; }
        /// <summary>
        /// Оставлено на хранение в производстве
        /// </summary>
        [DisplayName("Оставлено на хранение в производстве")]
        public bool IsStoredInProduction { get; set; }
        /// <summary>
        /// Израсходовано на 1000 уп., кг
        /// </summary>
        [DisplayName("Израсходовано на 1000 уп., кг")]
        public int ExpenseFor1000Packs { get; set; }
        /// <summary>
        /// Соответствует норме расхода
        /// </summary>
        [DisplayName("Соответствует норме расхода")]
        public bool IsCorrespondsToConsumptionRate { get; set; }
        /// <summary>
        /// "Сверка, %
        /// </summary>
        [DisplayName("Сверка, %")]
        public int Reconciliation { get; set; }
        /// <summary>
        /// Соответствует критериям приемлемости
        /// </summary>
        [DisplayName("Соответствует критериям приемлемости")]
        public bool IsCorrespondenceEligibilityCriteria { get; set; }


        //Группа «Наблюдения»:
        /// <summary>
        /// Наблюдения
        /// </summary>
        [DisplayName("Наблюдения")]
        public string Observations { get; set; }
        /// <summary>
        /// Мастер смены/бригадир
        /// </summary>
        [DisplayName("Мастер смены/бригадир")]
        [XmlIgnore]
        public User ShiftMaster { get; set; }
        public int? ShiftMasterId { get; set; }
        /// <summary>
        /// Дата
        /// </summary>
        [DisplayName("Дата")]
        public DateTime Date { get; set; }
        

    }
}