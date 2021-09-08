using System;
using System.ComponentModel;

namespace NanolekPrototype.EntityModels.Models
{
    public class TableSampleSelection
    {
        public int Id { get; set; }
        public FormSamplingFinishedProduct FormSamplingFinishedProduct { get; set; }
        public int FormSamplingFinishedProductId { get; set; }
        public bool IsActive { get; set; }


        [DisplayName("Дата время")]
        public DateTime DateTime { get; set; }
        [DisplayName("Количество отобранной пробы")]
        public int CountOfSampleSelection { get; set; }
        [DisplayName("Работник ОКК")]
        public User EmployeeOKK { get; set; }
        public int? EmployeeOKKId { get; set; }
    }
}