using System;
using System.ComponentModel;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class TableProcedure
    {
        public int Id { get; set; }
        public FormSamplingFinishedProduct FormSamplingFinishedProduct { get; set; }
        public int FormSamplingFinishedProductId { get; set; }
        public bool IsActive { get; set; }

        [DisplayName("Процедура")]
        public Procedure Procedure { get; set; }
        [DisplayName("Факт исполнения")]
        public bool IsCompleted { get; set; }
        [DisplayName("Исполнитель")]
        public User Executor { get; set; }
        public int? ExecutorId { get; set; }
        [DisplayName("Проверяющий")]
        public User Checker { get; set; }
        public int? CheckerId { get; set; }
        [DisplayName("Дата отметки")]
        public DateTime? ProcedureMarkDate { get; set; }
    }
}