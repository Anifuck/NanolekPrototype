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
    ///	Отбор проб готового продукта
    /// </summary>
    [Serializable()]
    public class FormSamplingFinishedProduct : PackagingProtocolForm
    {
        /// <summary>
        /// Тип
        /// </summary>
        [NotMapped]
        [DisplayName("Тип")]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.SamplingFinishedProduct;


        //Основное
        /// <summary>
        /// Номер извещения
        /// </summary>
        [DisplayName("Номер извещения")]
        public string NotificationNUmber { get; set; }
        /// <summary>
        /// Дата составления извещения
        /// </summary>
        [DisplayName("Дата составления извещения")]
        public DateTime NotificationDate { get; set; }
        /// <summary>
        /// Мастер смены
        /// </summary>
        [DisplayName("Мастер смены")]
        [XmlIgnore]
        public User ShiftMaster { get; set; }
        public int? ShiftMasterId { get; set; }
        /// <summary>
        /// Номер протокола
        /// </summary>
        [DisplayName("Номер протокола")]
        public string ProtocolNumber { get; set; }


        //Таблица «Отбор проб»:
        /// <summary>
        /// Таблица «Отбор проб»
        /// </summary>
        [XmlArray("SampleSelections")]
        [XmlArrayItem("SampleSelection", typeof(TableSampleSelection))]
        public List<TableSampleSelection> SampleSelections { get; set; }


        //Таблица «Процедуры»:
        /// <summary>
        /// Таблица «Процедуры»
        /// </summary>
        [XmlArray("TableProcedures")]
        [XmlArrayItem("TableProcedure", typeof(TableProcedure))]
        public List<TableProcedure> TableProcedures { get; set; }


        //Группа «Наблюдения»:
        /// <summary>
        /// Наблюдения
        /// </summary>
        [DisplayName("Наблюдения")]
        public string Observations { get; set; }
        /// <summary>
        /// Мастер смены/бригадир
        /// </summary>
        [DisplayName("Мастер смены/бригадир")]
        [XmlIgnore]
        public User TaskMaster { get; set; }
        public int? TaskMasterId { get; set; }
        /// <summary>
        /// Дата
        /// </summary>
        [DisplayName("Дата")]
        public DateTime Date { get; set; }

    }
}