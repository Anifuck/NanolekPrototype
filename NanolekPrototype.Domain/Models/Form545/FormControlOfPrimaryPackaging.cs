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
    public class FormControlOfPrimaryPackaging: PackagingProtocolForm
    {
        [NotMapped]
        [DisplayName("Тип")]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.ControlOfPrimaryPackaging;

        //Таблица «Контроль упаковки»:
        [XmlArray("PackagingControls")]
        [XmlArrayItem("PackagingControl", typeof(TablePackagingControl))]
        public List<TablePackagingControl> PackagingControls { get; set; }
    }
}