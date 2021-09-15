using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NanolekPrototype.EntityModels.Models
{
    [Serializable()]
    public class TableMovementOfBulkProduct
    {
        public int Id { get; set; }
        [XmlIgnore]
        public FormReceptionAndMovementOfBulkProduct FormReceptionAndMovementOfBulkProduct { get; set; }
        public int FormReceptionAndMovementOfBulkProductId { get; set; }
        public bool IsActive { get; set; }

        [DisplayName("Отходы балк-продукта, кг")]
        public int GarbageKg { get; set; }
        [DisplayName("Исполнитель")]
        [XmlIgnore]
        public User Executor { get; set; }
        public int ExecutorId { get; set; }
    }
}