using System;
using System.Collections;
using System.Collections.Generic;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormCheckingRejectionOfDefectiveTablet
    {
        public int Id { get; set; }
        public PackagingProtocol PackagingProtocol { get; set; }
        public bool IsActive { get; set; }
        public FormStatus FormStatus { get; set; }

        //Основное
        public DateTime CheckingDate { get; set; }

        // Таблица «Действия по проверке»:
        public ICollection<VerificationAction> VerificationActions { get; set; }
    }
}