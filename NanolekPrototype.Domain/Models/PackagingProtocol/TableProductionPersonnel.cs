using System;
using System.ComponentModel;
using System.Xml.Serialization;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    [Serializable()]
    public class TableProductionPersonnel
    {
        public int Id { get; set; }
        [XmlIgnore]

        public PackagingProtocol PackagingProtocol { get; set; }
        public int PackagingProtocolId { get; set; }
        public bool IsActive { get; set; }


        [DisplayName("ФИО")]
        public User FullName { get; set; }
        public int FullNameId { get; set; }
        [DisplayName("Должность")]
        public string Position { get; set; }
        [DisplayName("Этап")]
        public ProductionPersonnelStep Step { get; set; }
        [DisplayName("Роль")]
        public ProductionPersonnelRole Role { get; set; }
    }
}