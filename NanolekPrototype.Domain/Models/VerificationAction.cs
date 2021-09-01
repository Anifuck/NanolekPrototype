namespace NanolekPrototype.EntityModels.Models
{
    public class VerificationAction
    {
        public int Id { get; set; }
        public FormCheckingRejectionOfDefectiveTablet FormCheckingRejectionOfDefectiveTablet { get; set; }
        public int FormCheckingRejectionOfDefectiveTabletId { get; set; }
        public bool IsActive { get; set; }


        public string Action { get; set; }
        public bool IsApproved { get; set; }
        public User TaskMaster { get; set; }
    }
}