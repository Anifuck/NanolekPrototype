using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormSamplingFinishedProduct : PackagingProtocolForm
    {
        [NotMapped]
        [DisplayName("Тип")]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.SamplingFinishedProduct;


        //Основное
        [DisplayName("Номер извещения")]
        public string NotificationNUmber { get; set; }
        [DisplayName("Дата составления извещения")]
        public DateTime NotificationDate { get; set; }
        [DisplayName("Мастер смены")]
        public User ShiftMaster { get; set; }
        public int? ShiftMasterId { get; set; }
        [DisplayName("Номер протокола")]
        public string ProtocolNumber { get; set; }


        //Таблица «Отбор проб»:
        public ICollection<TableSampleSelection> SampleSelections { get; set; }


        //Таблица «Процедуры»:
        public ICollection<TableProcedure> TableProcedures { get; set; }


        //Группа «Наблюдения»:
        [DisplayName("Наблюдения")]
        public string Observations { get; set; }
        [DisplayName("Мастер смены/бригадир")]
        public User TaskMaster { get; set; }
        public int? TaskMasterId { get; set; }
        [DisplayName("Дата")]
        public DateTime Date { get; set; }

    }
}