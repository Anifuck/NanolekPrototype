using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace NanolekPrototype.EntityModels.Models
{
    [Serializable()]
    public class TablePackagingControl
    {
        public int Id { get; set; }
        [XmlIgnore]
        public FormControlOfPrimaryPackaging FormControlOfPrimaryPackaging { get; set; }
        public int FormControlOfPrimaryPackagingId { get; set; }
        public bool IsActive { get; set; }

        [DisplayName("Дата (не реже 1 раза в 15 минут)")]
        public DateTime Date { get; set; }
        [DisplayName("Соответствие фольги приложению к спецификации")]
        public bool IsFoilCorrespondenceToSpecification { get; set; }
        [DisplayName("Внешний вид блистера без дефектов")]
        public bool IsAppereanceWithoutDefects { get; set; }
        [DisplayName("Чёткость маркировки и рисунка рифления")]
        public bool IsClarityMarkAndCorrugationPattern { get; set; }
        [DisplayName("Соответствие переменных данных на блистере")]
        public bool IsMatchingVariableData { get; set; }
        [DisplayName("Балк-продукт не имеет видимых повреждений")]
        public bool IsBulkProductWithoutVisibleDamage { get; set; }
        [DisplayName("Количество таблеток в блистере соответствует")]
        public bool IsCorrespondsCountOfTabletsInBlister { get; set; }
        [DisplayName("Фактическая температура формирования ячеек °С (мин)")]
        public int ActualTemperatureOfCellFormingMin { get; set; }
        [DisplayName("Фактическая температура формирования ячеек °С (макс)")]
        public int ActualTemperatureOfCellFormingMax { get; set; }
        [DisplayName("Фактическая температура спайки блистера, ºС")]
        public int ActualTemperatureOfBlisterAdhesion { get; set; }
        [DisplayName("Скорость блистерования, бл./мин.")]
        public int BlisteringSpeed { get; set; }
        [DisplayName("ФИО укладчика упаковщика/оператора линии")]
        [XmlIgnore]
        public User TaskMaster { get; set; }
        public int? TaskMasterId { get; set; }

    }
}