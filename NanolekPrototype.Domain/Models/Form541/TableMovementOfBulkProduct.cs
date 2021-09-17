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

        /// <summary>
        /// Отходы балк-продукта, кг
        /// </summary>
        [DisplayName("Отходы балк-продукта, кг")]
        public int GarbageKg { get; set; }
        /// <summary>
        /// Исполнитель
        /// </summary>
        [DisplayName("Исполнитель")]
        [XmlIgnore]
        public User Executor { get; set; }
        public int ExecutorId { get; set; }
    }
}