using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormSamplingFinishedProduct : PackagingProtocolForm
    {
        [NotMapped]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.SamplingFinishedProduct;


        //Основное
        public string NotificationNUmber { get; set; }
        public DateTime NotificationDate { get; set; }
        public User ShiftMaster { get; set; }
        public string ProtocolNumber { get; set; }


        //Таблица «Отбор проб»:
        public ICollection<SampleSelection> SampleSelections { get; set; }


        //Таблица «Процедуры»:
        public ICollection<TableProcedure> TableProcedures { get; set; }


        //Группа «Наблюдения»:
        public string Observations { get; set; }
        public User TaskMaster { get; set; }
        public DateTime Date { get; set; }

    }
}