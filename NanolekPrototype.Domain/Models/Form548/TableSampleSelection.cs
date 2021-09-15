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


        [DisplayName("Дата время")]
        public DateTime DateTime { get; set; }
        [DisplayName("Количество отобранной пробы")]
        public int CountOfSampleSelection { get; set; }
        [DisplayName("Работник ОКК")]
        [XmlIgnore]
        public User EmployeeOKK { get; set; }
        public int? EmployeeOKKId { get; set; }
    }
}