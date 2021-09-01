using System;

namespace NanolekPrototype.EntityModels.Models
{
    public class TableReceptionOfMaterial
    {
        public int Id { get; set; }
        public FormReceptionAndMovementOfPackingMaterial FormReceptionAndMovementOfPackingMaterial { get; set; }
        public int FormReceptionAndMovementOfPackingMaterialId { get; set; }
        public bool IsActive { get; set; }



        public DateTime Date { get; set; }
        public int ReceivedFoil { get; set; }
        public int RemainingProduction { get; set; }
        public string SAPPart { get; set; }
        public string ManufacturerSerialNumber { get; set; }
        public int AnalyticalSheetNumberOKK { get; set; }
        public bool IsFoilMeetsControlParameters { get; set; }
        public User ShiftMaster { get; set; }
    }
}