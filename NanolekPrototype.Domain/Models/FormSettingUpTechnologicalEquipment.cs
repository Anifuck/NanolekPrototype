using System.Collections;
using System.Collections.Generic;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormSettingUpTechnologicalEquipment
    {
        public int Id { get; set; }
        public PackagingProtocol PackagingProtocol { get; set; }
        public bool IsActive { get; set; }
        public FormStatus FormStatus { get; set; }

        //Таблица «Настройка технологического оборудования»:

        public ICollection<SettingUpTechnologicalEquipment> SettingUpTechnologicalEquipments { get; set; }

    }
}