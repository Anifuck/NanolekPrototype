using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class TableProductionPersonnel
    {
        public int Id { get; set; }
        public PackagingProtocol PackagingProtocol { get; set; }
        public int PackagingProtocolId { get; set; }
        public bool IsActive { get; set; }


        public User FullName { get; set; }
        public string Position { get; set; }
        public ProductionPersonnelStep Step { get; set; }
        public ProductionPersonnelRole Role { get; set; }
    }
}