using System;
using System.ComponentModel;
using System.Xml.Serialization;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    [Serializable()]
    public class TableProcedure
    {
        public int Id { get; set; }
        [XmlIgnore]
        public FormSamplingFinishedProduct FormSamplingFinishedProduct { get; set; }
        public int FormSamplingFinishedProductId { get; set; }
        public bool IsActive { get; set; }

        /// <summary>
        /// Процедура
        /// </summary>
        [DisplayName("Процедура")]
        public Procedure Procedure { get; set; }
        /// <summary>
        /// Факт исполнения
        /// </summary>
        [DisplayName("Факт исполнения")]
        public bool IsCompleted { get; set; }
        /// <summary>
        /// Исполнитель
        /// </summary>
        [DisplayName("Исполнитель")]
        [XmlIgnore]
        public User Executor { get; set; }
        public int? ExecutorId { get; set; }
        /// <summary>
        /// Проверяющий
        /// </summary>
        [DisplayName("Проверяющий")]
        [XmlIgnore]
        public User Checker { get; set; }
        public int? CheckerId { get; set; }
        /// <summary>
        /// Дата отметки
        /// </summary>
        [DisplayName("Дата отметки")]
        public DateTime? ProcedureMarkDate { get; set; }
    }
}