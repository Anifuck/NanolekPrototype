using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormCheckingCheckweighingSetting : PackagingProtocolForm
    {

        [NotMapped]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.CheckingCheckweighingSetting;

        //Таблица «Процедуры проверки»
        public ICollection<CheckingProcedure> CheckingProcedures { get; set; }

    }
}