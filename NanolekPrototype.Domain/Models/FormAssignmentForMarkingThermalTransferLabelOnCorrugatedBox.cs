using System;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox
    {
        public int Id { get; set; }
        public PackagingProtocol PackagingProtocol { get; set; }
        public bool IsActive { get; set; }
        public FormStatus FormStatus { get; set; }

        
        //Основное 
        public string GTIN { get; set; }
        public int Series { get; set; }
        public DateTime DateOfManufacture { get; set; }
        public PacksInCorrugatedBox PacksInCorrugatedBox { get; set; }
        public InternalCode InternalCode { get; set; }
        public User TaskGiven { get; set; }
        public DateTime TaskGivenDate { get; set; }
        public User TaskGot{ get; set; }
        public DateTime TaskGotDate { get; set; }
    }
}