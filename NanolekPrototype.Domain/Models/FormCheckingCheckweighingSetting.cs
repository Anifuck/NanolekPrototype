using System.Collections;
using System.Collections.Generic;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormCheckingCheckweighingSetting
    {
        public int Id { get; set; }
        public PackagingProtocol PackagingProtocol { get; set; }
        public bool IsActive { get; set; }
        public FormStatus FormStatus { get; set; }

        //Таблица «Процедуры проверки»
        public ICollection<CheckingProcedure> CheckingProcedures { get; set; }

    }
}