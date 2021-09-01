using System;
using System.Collections.Generic;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormReceptionAndMovementOfPackingMaterial
    {
        public int Id { get; set; }
        public PackagingProtocol PackagingProtocol { get; set; }
        public bool IsActive { get; set; }
        public FormStatus FormStatus { get; set; }

        //Группа «Основное»
        public int InternalCodeOfMaterial { get; set; }
        public string Specification { get; set; }
        public User CalcedByUser { get; set; }
        public DateTime CalcedByUserDate { get; set; }
        public User CheckedByUser { get; set; }
        public DateTime CheckedByUserDate { get; set; }

        //Таблица «Приём материала»

        //Группа «Баланс по окончании серии»:
        public int SpentOnBatch { get; set; }
        public int RemainingMaterial { get; set; }
        public bool IsSentToStorage { get; set; }
        public bool IsStoredInProduction { get; set; }
        public int ExpenseFor1000Packs { get; set; }
        public bool IsCorrespondsToConsumptionRate { get; set; }
        public int Reconciliation { get; set; }
        public bool IsCorrespondenceEligibilityCriteria { get; set; }


        //Группа «Наблюдения»:
        public string Observations { get; set; }
        public User ShiftMaster { get; set; }
        public DateTime Date { get; set; }

        public ICollection<ReceptionOfMaterial> ReceptionOfMaterials { get; set; }
    }
}