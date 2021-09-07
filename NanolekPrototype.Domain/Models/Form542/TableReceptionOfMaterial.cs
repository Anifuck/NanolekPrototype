using System;
using System.ComponentModel;

namespace NanolekPrototype.EntityModels.Models
{
    public class TableReceptionOfMaterial
    {
        public int Id { get; set; }
        public FormReceptionAndMovementOfPackingMaterial FormReceptionAndMovementOfPackingMaterial { get; set; }
        public int FormReceptionAndMovementOfPackingMaterialId { get; set; }
        public bool IsActive { get; set; }


        [DisplayName("Дата")]
        public DateTime Date { get; set; }
        [DisplayName("Получено фольги по документации, кг")]
        public int ReceivedFoil { get; set; }
        [DisplayName("Остаток на производстве, кг")]
        public int RemainingProduction { get; set; }
        [DisplayName("Партия SAP")]
        public string SAPPart { get; set; }
        [DisplayName("Номер серии производителя")]
        public string ManufacturerSerialNumber { get; set; }
        [DisplayName("Номер Аналитического листа ОКК")]
        public int AnalyticalSheetNumberOKK { get; set; }
        [DisplayName("Фольга соответствует показателям контроля")]
        public bool IsFoilMeetsControlParameters { get; set; }
        [DisplayName("Мастер смены")]
        public User ShiftMaster { get; set; }
        public int? ShiftMasterId { get; set; }
    }
}