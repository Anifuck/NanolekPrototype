using System;
using System.ComponentModel;
using System.Xml.Serialization;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    [Serializable()]
    public class TableVerificationAction
    {
        public int Id { get; set; }
        [XmlIgnore]
        public FormCheckingRejectionOfDefectiveTablet FormCheckingRejectionOfDefectiveTablet { get; set; }
        public int FormCheckingRejectionOfDefectiveTabletId { get; set; }
        public bool IsActive { get; set; }


        [DisplayName("Действие")]
        public VerificationAction Action { get; set; }
        [DisplayName("Подтверждение действия")]
        public bool IsApproved { get; set; }
        [DisplayName("Бригадир")]
        [XmlIgnore]
        public User TaskMaster { get; set; }
        public int? TaskMasterId { get; set; }
    }
}