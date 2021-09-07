using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
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
        public ICollection<TableVerificationAction> VerificationActions { get; set; }
    }
}