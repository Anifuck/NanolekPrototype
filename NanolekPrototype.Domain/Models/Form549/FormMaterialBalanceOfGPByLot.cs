using System;
using System.ComponentModel.DataAnnotations.Schema;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormMaterialBalanceOfGPByLot : PackagingProtocolForm
    {
        [NotMapped]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.MaterialBalanceOfGPByLot;

        //Основное
        public DateTime StartDateOfPacking { get; set; }
        public DateTime FinishDateOfPacking { get; set; }
        public User ShiftMaster { get; set; }
        public DateTime ShiftMasterDate { get; set; }
        public User CalcedByUser { get; set; }
        public DateTime CalcedByUserDate { get; set; }
        public User CheckedByUser { get; set; }
        public DateTime CheckedByUserDate { get; set; }
        public User CheckedPUByUser { get; set; }
        public DateTime CheckedPUByUserDate { get; set; }

        //Группа «Итог упаковки»:
        public int PackagesCount { get; set; }
        public ExitAccordingToTheRegulations ExitAccordingToTheRegulations { get; set; }
        public bool IsCompliant { get; set; }

        //Группа «Наблюдения»:
        public string Observations { get; set; }
        public User TaskMaster { get; set; }
        public DateTime Date { get; set; }
    }
}