using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox : PackagingProtocolForm
    {
        [NotMapped]
        [DisplayName("Тип")]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.AssignmentForMarkingThermalTransferLabelOnCorrugatedBox;

        //Основное 
        [DisplayName("GTIN")]
        public GTIN GTIN { get; set; }
        [DisplayName("Серия")]
        public int Series { get; set; }
        [DisplayName("Дата изготовления")]
        public DateTime DateOfManufacture { get; set; }
        [DisplayName("Годен до")]
        public DateTime SellBy { get; set; }
        [DisplayName("Количество: (пачек в гофрокоробе)")]
        public PacksInCorrugatedBox PacksInCorrugatedBox { get; set; }
        [DisplayName("Внутренний код")]
        public InternalCode InternalCode { get; set; }
        [DisplayName("Задание дал (ФИО)")]
        public User TaskGiven { get; set; }
        public int? TaskGivenId { get; set; }
        [DisplayName("Задание дал (Дата)")]
        public DateTime TaskGivenDate { get; set; }
        [DisplayName("Задание получил (ФИО)")]
        public User TaskGot{ get; set; }
        public int? TaskGotId { get; set; }
        [DisplayName("Задание получил (Дата)")]
        public DateTime TaskGotDate { get; set; }
    }
}