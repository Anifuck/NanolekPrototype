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
    /// Настройка технологического оборудования
    /// </summary>
    [Serializable()]
    public class FormSettingUpTechnologicalEquipment : PackagingProtocolForm
    {
        /// <summary>
        /// Тип
        /// </summary>
        [NotMapped]
        [DisplayName("Тип")]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.SettingUpTechnologicalEquipment;

        //Таблица «Настройка технологического оборудования»:
        /// <summary>
        /// Таблица «Настройка технологического оборудования»
        /// </summary>
        [XmlArray("SettingUpTechnologicalEquipments")]
        [XmlArrayItem("SettingUpTechnologicalEquipment", typeof(TableSettingUpTechnologicalEquipment))]
        public List<TableSettingUpTechnologicalEquipment> SettingUpTechnologicalEquipments { get; set; }

    }
}