using System.ComponentModel;

namespace NanolekPrototype.EntityModels.Models
{
    public class TableMovementOfBulkProduct
    {
        public int Id { get; set; }
        public FormReceptionAndMovementOfBulkProduct FormReceptionAndMovementOfBulkProduct { get; set; }
        public int FormReceptionAndMovementOfBulkProductId { get; set; }
        public bool IsActive { get; set; }

        [DisplayName("Отходы балк-продукта, кг")]
        public int GarbageKg { get; set; }
        [DisplayName("Исполнитель")]
        public User Executor { get; set; }
        public int ExecutorId { get; set; }
    }
}