using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    /// <summary>
    /// Проверка отбраковки дефектных таблеток камерой блистерной машины
    /// </summary>
    [Serializable()]
    public class FormCheckingRejectionOfDefectiveTablet : PackagingProtocolForm
    {
        /// <summary>
        /// Тип
        /// </summary>
        [NotMapped]
        [DisplayName("Тип")]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.CheckingRejectionOfDefectiveTablet;

        //Основное
        /// <summary>
        /// Дата проверки
        /// </summary>
        [DisplayName("Дата проверки")]
        public DateTime CheckingDate { get; set; }

        // Таблица «Действия по проверке»:
        /// <summary>
        /// Таблица «Действия по проверке»
        /// </summary>
        [XmlArray("VerificationActions")]
        [XmlArrayItem("VerificationAction", typeof(TableVerificationAction))]
        public List<TableVerificationAction> VerificationActions { get; set; }
    }
}