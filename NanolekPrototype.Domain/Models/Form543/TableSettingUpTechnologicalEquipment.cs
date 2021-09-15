using System;
using System.ComponentModel;
using System.Xml.Serialization;
using Action = NanolekPrototype.EntityModels.Enums.Action;

namespace NanolekPrototype.EntityModels.Models
{
    [Serializable()]
    public class TableSettingUpTechnologicalEquipment
    {
        public int Id { get; set; }
        [XmlIgnore]
        public FormSettingUpTechnologicalEquipment FormSettingUpTechnologicalEquipment { get; set; }
        public int FormSettingUpTechnologicalEquipmentId { get; set; }
        public bool IsActive { get; set; }


        [DisplayName("Действие")]
        public Action Action { get; set; }
        [DisplayName("Подтверждение")]
        public bool IsApproved { get; set; }
        [DisplayName("Наладчик")]
        [XmlIgnore]
        public User ServiceTechnician { get; set; }
        public int? ServiceTechnicianId { get; set; }
    }
}