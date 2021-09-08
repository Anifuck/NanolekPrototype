using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormCheckingCheckweighingSetting : PackagingProtocolForm
    {

        [NotMapped]
        [DisplayName("Тип")]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.CheckingCheckweighingSetting;

        //Таблица «Процедуры проверки»
        public ICollection<TableCheckingProcedure> CheckingProcedures { get; set; }

    }
}