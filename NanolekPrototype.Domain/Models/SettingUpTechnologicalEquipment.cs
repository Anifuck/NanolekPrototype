namespace NanolekPrototype.EntityModels.Models
{
    public class SettingUpTechnologicalEquipment
    {
        public int Id { get; set; }
        public FormSettingUpTechnologicalEquipment FormSettingUpTechnologicalEquipment { get; set; }
        public int FormSettingUpTechnologicalEquipmentId { get; set; }
        public bool IsActive { get; set; }



        public string Action { get; set; }
        public bool IsApproved { get; set; }
        public User ServiceTechnician { get; set; }
    }
}