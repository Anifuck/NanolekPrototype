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
    public class FormSettingUpTechnologicalEquipment : PackagingProtocolForm
    {
        [NotMapped]
        [DisplayName("Тип")]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.SettingUpTechnologicalEquipment;

        //Таблица «Настройка технологического оборудования»:
        [XmlArray("SettingUpTechnologicalEquipments")]
        [XmlArrayItem("SettingUpTechnologicalEquipment", typeof(TableSettingUpTechnologicalEquipment))]
        public List<TableSettingUpTechnologicalEquipment> SettingUpTechnologicalEquipments { get; set; }

    }
}