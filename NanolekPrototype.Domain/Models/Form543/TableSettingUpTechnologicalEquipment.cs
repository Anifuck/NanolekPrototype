using System.ComponentModel;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class TableSettingUpTechnologicalEquipment
    {
        public int Id { get; set; }
        public FormSettingUpTechnologicalEquipment FormSettingUpTechnologicalEquipment { get; set; }
        public int FormSettingUpTechnologicalEquipmentId { get; set; }
        public bool IsActive { get; set; }


        [DisplayName("Действие")]
        public Action Action { get; set; }
        [DisplayName("Подтверждение")]
        public bool IsApproved { get; set; }
        [DisplayName("Наладчик")]
        public User ServiceTechnician { get; set; }
        public int? ServiceTechnicianId { get; set; }
    }
}