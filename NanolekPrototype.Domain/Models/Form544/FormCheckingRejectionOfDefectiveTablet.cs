using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    [Serializable()]
    public class FormCheckingRejectionOfDefectiveTablet : PackagingProtocolForm
    {
        [NotMapped]
        [DisplayName("Тип")]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.CheckingRejectionOfDefectiveTablet;

        //Основное
        [DisplayName("Дата проверки")]
        public DateTime CheckingDate { get; set; }

        // Таблица «Действия по проверке»:
        [XmlArray("VerificationActions")]
        [XmlArrayItem("VerificationAction", typeof(TableVerificationAction))]
        public List<TableVerificationAction> VerificationActions { get; set; }
    }
}