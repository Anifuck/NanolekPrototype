using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NanolekPrototype.EntityModels.Models
{
    [Serializable()]
    public class TableReceptionOfMaterial
    {
        public int Id { get; set; }
        [XmlIgnore]
        public FormReceptionAndMovementOfPackingMaterial FormReceptionAndMovementOfPackingMaterial { get; set; }
        public int FormReceptionAndMovementOfPackingMaterialId { get; set; }
        public bool IsActive { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        [DisplayName("Дата")]
        public DateTime Date { get; set; }
        /// <summary>
        /// Получено фольги по документации, кг
        /// </summary>
        [DisplayName("Получено фольги по документации, кг")]
        public int ReceivedFoil { get; set; }
        /// <summary>
        /// Остаток на производстве, кг
        /// </summary>
        [DisplayName("Остаток на производстве, кг")]
        public int RemainingProduction { get; set; }
        /// <summary>
        /// Партия SAP
        /// </summary>
        [DisplayName("Партия SAP")]
        public string SAPPart { get; set; }
        /// <summary>
        /// Номер серии производителя
        /// </summary>
        [DisplayName("Номер серии производителя")]
        public string ManufacturerSerialNumber { get; set; }
        /// <summary>
        /// Номер Аналитического листа ОКК
        /// </summary>
        [DisplayName("Номер Аналитического листа ОКК")]
        public int AnalyticalSheetNumberOKK { get; set; }
        /// <summary>
        /// Фольга соответствует показателям контроля
        /// </summary>
        [DisplayName("Фольга соответствует показателям контроля")]
        public bool IsFoilMeetsControlParameters { get; set; }
        /// <summary>
        /// "Мастер смены
        /// </summary>
        [DisplayName("Мастер смены")]
        [XmlIgnore]
        public User ShiftMaster { get; set; }
        public int? ShiftMasterId { get; set; }
    }
}