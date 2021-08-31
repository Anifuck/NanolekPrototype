namespace NanolekPrototype.EntityModels.Models
{
    public class MovementOfBulkProduct
    {
        public int Id { get; set; }
        public FormReceptionAndMovementOfBulkProduct FormReceptionAndMovementOfBulkProduct { get; set; }
        public int FormReceptionAndMovementOfBulkProductId { get; set; }
        public bool IsActive { get; set; }


        public int GarbageKg { get; set; }
        public User Executor { get; set; }
    }
}