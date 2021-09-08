﻿using System;
using System.ComponentModel;

namespace NanolekPrototype.EntityModels.Models
{
    public class TableCheckingProcedure
    {
        public int Id { get; set; }
        public FormCheckingCheckweighingSetting FormCheckingCheckweighingSetting { get; set; }
        public int FormCheckingCheckweighingSettingId { get; set; }
        public bool IsActive { get; set; }

        [DisplayName("Дата/время")]
        public DateTime DateTime { get; set; }
        [DisplayName("Процедура")]
        public string Procedure { get; set; }
        [DisplayName("Факт выполнения")]
        public bool IsComplete { get; set; }
        [DisplayName("Эталонная масса пачки ГП")]
        public double ReferenceWeightOfGPPack { get; set; }
        [DisplayName("Фактическая масса пачки ГП")]
        public double ActualWeightOfGPPack { get; set; }
        [DisplayName("Примечание")]
        public string Note { get; set; }
        [DisplayName("Исполнитель")]
        public User Executor { get; set; }
        public int? ExecutorId { get; set; }
    }
}