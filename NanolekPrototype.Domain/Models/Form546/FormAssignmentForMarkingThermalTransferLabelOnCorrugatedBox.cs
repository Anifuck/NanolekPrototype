using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    /// <summary>
    ///	Задание на маркировку этикетки термотрансферной на гофрокороб
    /// </summary>
    [Serializable()]
    public class FormAssignmentForMarkingThermalTransferLabelOnCorrugatedBox : PackagingProtocolForm
    {
        /// <summary>
        /// Тип
        /// </summary>
        [NotMapped]
        [DisplayName("Тип")]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.AssignmentForMarkingThermalTransferLabelOnCorrugatedBox;

        //Основное 
        /// <summary>
        /// GTIN
        /// </summary>
        [DisplayName("GTIN")]
        public GTIN GTIN { get; set; }
        /// <summary>
        /// Серия
        /// </summary>
        [DisplayName("Серия")]
        public int Series { get; set; }
        /// <summary>
        /// Дата изготовления
        /// </summary>
        [DisplayName("Дата изготовления")]
        public DateTime DateOfManufacture { get; set; }
        /// <summary>
        /// Годен до
        /// </summary>
        [DisplayName("Годен до")]
        public DateTime SellBy { get; set; }
        /// <summary>
        /// Количество: (пачек в гофрокоробе)
        /// </summary>
        [DisplayName("Количество: (пачек в гофрокоробе)")]
        public PacksInCorrugatedBox PacksInCorrugatedBox { get; set; }
        /// <summary>
        /// Внутренний код
        /// </summary>
        [DisplayName("Внутренний код")]
        public InternalCode InternalCode { get; set; }
        /// <summary>
        /// Задание дал (ФИО)
        /// </summary>
        [DisplayName("Задание дал (ФИО)")]
        [XmlIgnore]
        public User TaskGiven { get; set; }
        public int? TaskGivenId { get; set; }
        /// <summary>
        /// Задание дал (Дата)
        /// </summary>
        [DisplayName("Задание дал (Дата)")]
        public DateTime TaskGivenDate { get; set; }
        /// <summary>
        /// Задание получил (ФИО)
        /// </summary>
        [DisplayName("Задание получил (ФИО)")]
        [XmlIgnore]
        public User TaskGot{ get; set; }
        public int? TaskGotId { get; set; }
        /// <summary>
        /// Задание получил (Дата)
        /// </summary>
        [DisplayName("Задание получил (Дата)")]
        public DateTime TaskGotDate { get; set; }
    }
}