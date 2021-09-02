namespace NanolekPrototype.EntityModels.Models
{
    public class TableMovementOfBulkProduct
    {
        public int Id { get; set; }
        public FormReceptionAndMovementOfBulkProduct FormReceptionAndMovementOfBulkProduct { get; set; }
        public bool IsActive { get; set; }


        public int GarbageKg { get; set; }
        public User Executor { get; set; }
    }
}