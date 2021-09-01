namespace NanolekPrototype.EntityModels.Models
{
    public class TableProcedure
    {
        public int Id { get; set; }
        public FormSamplingFinishedProduct FormSamplingFinishedProduct { get; set; }
        public int FormSamplingFinishedProductId { get; set; }
        public bool IsActive { get; set; }

        public Procedure Procedure { get; set; }
        public bool IsCompleted { get; set; }
        public User Executor { get; set; }
        public User Checker { get; set; }
    }
}