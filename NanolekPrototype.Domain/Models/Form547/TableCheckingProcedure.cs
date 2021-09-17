using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NanolekPrototype.EntityModels.Models
{
    [Serializable()]
    public class TableCheckingProcedure
    {
        public int Id { get; set; }
        [XmlIgnore]
        public FormCheckingCheckweighingSetting FormCheckingCheckweighingSetting { get; set; }
        public int FormCheckingCheckweighingSettingId { get; set; }
        public bool IsActive { get; set; }

        /// <summary>
        /// Дата/время
        /// </summary>
        [DisplayName("Дата/время")]
        public DateTime DateTime { get; set; }
        /// <summary>
        /// Процедура
        /// </summary>
        [DisplayName("Процедура")]
        public string Procedure { get; set; }
        /// <summary>
        /// Факт выполнения
        /// </summary>
        [DisplayName("Факт выполнения")]
        public bool IsComplete { get; set; }
        /// <summary>
        /// Эталонная масса пачки ГП
        /// </summary>
        [DisplayName("Эталонная масса пачки ГП")]
        public double ReferenceWeightOfGPPack { get; set; }
        /// <summary>
        /// Фактическая масса пачки ГП
        /// </summary>
        [DisplayName("Фактическая масса пачки ГП")]
        public double ActualWeightOfGPPack { get; set; }
        /// <summary>
        /// Примечание
        /// </summary>
        [DisplayName("Примечание")]
        public string Note { get; set; }
        /// <summary>
        /// Исполнитель
        /// </summary>
        [DisplayName("Исполнитель")]
        [XmlIgnore]
        public User Executor { get; set; }
        public int? ExecutorId { get; set; }
    }
}