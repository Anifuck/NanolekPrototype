using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormSettingUpTechnologicalEquipment : PackagingProtocolForm
    {
        [NotMapped]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.SettingUpTechnologicalEquipment;

        //Таблица «Настройка технологического оборудования»:
        public ICollection<TableSettingUpTechnologicalEquipment> SettingUpTechnologicalEquipments { get; set; }

    }
}