using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormReceptionAndMovementOfPackingMaterial : PackagingProtocolForm
    {
        [NotMapped]
        [DisplayName("Тип")]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.ReceptionAndMovementOfPackingMaterial;

        //Группа «Основное»
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
        public int? CheckedByUserId { get; set; }
        [DisplayName("Расчет проверил (Дата)")]
        public DateTime CheckedByUserDate { get; set; }

        //Таблица «Приём материала»
        public ICollection<TableReceptionOfMaterial> ReceptionOfMaterials { get; set; }

        //Группа «Баланс по окончании серии»:
        [DisplayName("Израсходовано на серию, кг")]
        public int SpentOnBatch { get; set; }
        [DisplayName("Остаток материала, кг")]
        public int RemainingMaterial { get; set; }
        [DisplayName("Передано на склад")]
        public bool IsSentToStorage { get; set; }
        [DisplayName("Оставлено на хранение в производстве")]
        public bool IsStoredInProduction { get; set; }
        [DisplayName("Израсходовано на 1000 уп., кг")]
        public int ExpenseFor1000Packs { get; set; }
        [DisplayName(" Соответствует норме расхода")]
        public bool IsCorrespondsToConsumptionRate { get; set; }
        [DisplayName("Сверка, %")]
        public int Reconciliation { get; set; }
        [DisplayName("Соответствует критериям приемлемости")]
        public bool IsCorrespondenceEligibilityCriteria { get; set; }
   

        //Группа «Наблюдения»:
        [DisplayName("Наблюдения")]
        public string Observations { get; set; }
        [DisplayName("Мастер смены/бригадир")]
        public User ShiftMaster { get; set; }
        public int? ShiftMasterId { get; set; }
        [DisplayName("Дата")]
        public DateTime Date { get; set; }

    }
}