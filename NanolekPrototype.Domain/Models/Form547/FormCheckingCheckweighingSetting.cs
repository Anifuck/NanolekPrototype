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
    public class FormCheckingCheckweighingSetting : PackagingProtocolForm
    {

        [NotMapped]
        [DisplayName("Тип")]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.CheckingCheckweighingSetting;

        [XmlArray("CheckingProcedures")]
        [XmlArrayItem("CheckingProcedure", typeof(TableCheckingProcedure))]
        //Таблица «Процедуры проверки»
        public List<TableCheckingProcedure> CheckingProcedures { get; set; }

    }
}