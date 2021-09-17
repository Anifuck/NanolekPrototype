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
    ///	Проверка настройки контрольных весов
    /// </summary>
    [Serializable()]
    public class FormCheckingCheckweighingSetting : PackagingProtocolForm
    {
        /// <summary>
        /// Тип
        /// </summary>
        [NotMapped]
        [DisplayName("Тип")]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.CheckingCheckweighingSetting;

        //Таблица «Процедуры проверки»
        /// <summary>
        /// Таблица «Процедуры проверки»
        /// </summary>
        [XmlArray("CheckingProcedures")]
        [XmlArrayItem("CheckingProcedure", typeof(TableCheckingProcedure))]
        public List<TableCheckingProcedure> CheckingProcedures { get; set; }

    }
}