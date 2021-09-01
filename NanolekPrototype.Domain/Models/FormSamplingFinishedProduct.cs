using System;
using System.Collections;
using System.Collections.Generic;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormSamplingFinishedProduct
    {
        public int Id { get; set; }
        public PackagingProtocol PackagingProtocol { get; set; }
        public bool IsActive { get; set; }
        public FormStatus FormStatus { get; set; }


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