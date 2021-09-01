using System;
using System.ComponentModel.DataAnnotations.Schema;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox : PackagingProtocolForm
    {
        [NotMapped]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.AssignmentForMarkingThermalTransferLabelOnCorrugatedBox;

        //Основное 
        public GTIN GTIN { get; set; }
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