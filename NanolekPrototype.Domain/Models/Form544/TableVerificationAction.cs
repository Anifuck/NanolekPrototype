using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class TableVerificationAction
    {
        public int Id { get; set; }
        public FormCheckingRejectionOfDefectiveTablet FormCheckingRejectionOfDefectiveTablet { get; set; }
        public int FormCheckingRejectionOfDefectiveTabletId { get; set; }
        public bool IsActive { get; set; }


        public VerificationAction Action { get; set; }
        public bool IsApproved { get; set; }
        public User TaskMaster { get; set; }
    }
}