using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NanolekPrototype.EntityModels.Models
{
    [Serializable]
    public class TableSampleSelection
    {
        public int Id { get; set; }
        [XmlIgnore]
        public FormSamplingFinishedProduct FormSamplingFinishedProduct { get; set; }
        public int FormSamplingFinishedProductId { get; set; }
        public bool IsActive { get; set; }

        /// <summary>
        /// Дата время
        /// </summary>
        [DisplayName("Дата время")]
        public DateTime DateTime { get; set; }
        /// <summary>
        /// Количество отобранной пробы
        /// </summary>
        [DisplayName("Количество отобранной пробы")]
        public int CountOfSampleSelection { get; set; }
        /// <summary>
        /// Работник ОКК
        /// </summary>
        [DisplayName("Работник ОКК")]
        [XmlIgnore]
        public User EmployeeOKK { get; set; }
        public int? EmployeeOKKId { get; set; }
    }
}