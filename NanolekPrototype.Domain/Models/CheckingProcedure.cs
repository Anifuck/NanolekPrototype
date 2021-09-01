using System;

namespace NanolekPrototype.EntityModels.Models
{
    public class CheckingProcedure
    {
        public int Id { get; set; }
        public FormCheckingCheckweighingSetting FormCheckingCheckweighingSetting { get; set; }
        public int FormCheckingCheckweighingSettingId { get; set; }
        public bool IsActive { get; set; }

        public DateTime DateTime { get; set; }
        public string Procedure { get; set; }
        public bool IsComplete { get; set; }
        public double ReferenceWeightOfGPPack { get; set; }
        public double ActualWeightOfGPPack { get; set; }
        public string Note { get; set; }
        public User Executor { get; set; }
    }
}