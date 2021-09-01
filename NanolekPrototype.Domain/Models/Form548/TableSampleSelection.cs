using System;

namespace NanolekPrototype.EntityModels.Models
{
    public class TableSampleSelection
    {
        public int Id { get; set; }
        public FormSamplingFinishedProduct FormSamplingFinishedProduct { get; set; }
        public int FormSamplingFinishedProductId { get; set; }
        public bool IsActive { get; set; }



        public DateTime DateTime { get; set; }
        public int CountOfSampleSelection { get; set; }
        public User EmployeeOKK { get; set; }
    }
}