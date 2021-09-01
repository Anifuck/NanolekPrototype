using System;

namespace NanolekPrototype.EntityModels.Models
{
    public class TablePackagingControl
    {
        public int Id { get; set; }
        public FormControlOfPrimaryPackaging FormControlOfPrimaryPackaging { get; set; }
        public int FormControlOfPrimaryPackagingId { get; set; }
        public bool IsActive { get; set; }

        public DateTime Date { get; set; }
        public bool IsFoilCorrespondenceToSpecification { get; set; }
        public bool IsAppereanceWithoutDefects { get; set; }
        public bool IsClarityMarkAndCorrugationPattern { get; set; }
        public bool IsMatchingVariableData { get; set; }
        public bool IsBulkProductWithoutVisibleDamage { get; set; }
        public bool IsCorrespondsCountOfTabletsInBlister { get; set; }
        public int ActualTemperatureOfCellFormingMin { get; set; }
        public int ActualTemperatureOfCellFormingMax { get; set; }
        public int ActualTemperatureOfBlisterAdhesion { get; set; }
        public int BlisteringSpeed { get; set; }
        public User TaskMaster { get; set; }

    }
}