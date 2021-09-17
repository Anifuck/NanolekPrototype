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

        /// <summary>
        /// Дата (не реже 1 раза в 15 минут)
        /// </summary>
        [DisplayName("Дата (не реже 1 раза в 15 минут)")]
        public DateTime Date { get; set; }
        /// <summary>
        /// Соответствие фольги приложению к спецификации
        /// </summary>
        [DisplayName("Соответствие фольги приложению к спецификации")]
        public bool IsFoilCorrespondenceToSpecification { get; set; }
        /// <summary>
        /// Внешний вид блистера без дефектов
        /// </summary>
        [DisplayName("Внешний вид блистера без дефектов")]
        public bool IsAppereanceWithoutDefects { get; set; }
        /// <summary>
        /// Чёткость маркировки и рисунка рифления
        /// </summary>
        [DisplayName("Чёткость маркировки и рисунка рифления")]
        public bool IsClarityMarkAndCorrugationPattern { get; set; }
        /// <summary>
        /// Соответствие переменных данных на блистере
        /// </summary>
        [DisplayName("Соответствие переменных данных на блистере")]
        public bool IsMatchingVariableData { get; set; }
        /// <summary>
        /// Балк-продукт не имеет видимых повреждений
        /// </summary>
        [DisplayName("Балк-продукт не имеет видимых повреждений")]
        public bool IsBulkProductWithoutVisibleDamage { get; set; }
        /// <summary>
        /// Количество таблеток в блистере соответствует
        /// </summary>
        [DisplayName("Количество таблеток в блистере соответствует")]
        public bool IsCorrespondsCountOfTabletsInBlister { get; set; }
        /// <summary>
        /// Фактическая температура формирования ячеек °С (мин)
        /// </summary>
        [DisplayName("Фактическая температура формирования ячеек °С (мин)")]
        public int ActualTemperatureOfCellFormingMin { get; set; }
        /// <summary>
        /// Фактическая температура формирования ячеек °С (макс)
        /// </summary>
        [DisplayName("Фактическая температура формирования ячеек °С (макс)")]
        public int ActualTemperatureOfCellFormingMax { get; set; }
        /// <summary>
        /// Фактическая температура спайки блистера, ºС
        /// </summary>
        [DisplayName("Фактическая температура спайки блистера, ºС")]
        public int ActualTemperatureOfBlisterAdhesion { get; set; }
        /// <summary>
        /// Скорость блистерования, бл./мин.
        /// </summary>
        [DisplayName("Скорость блистерования, бл./мин.")]
        public int BlisteringSpeed { get; set; }
        /// <summary>
        /// ФИО укладчика упаковщика/оператора линии
        /// </summary>
        [DisplayName("ФИО укладчика упаковщика/оператора линии")]
        [XmlIgnore]
        public User TaskMaster { get; set; }
        public int? TaskMasterId { get; set; }

    }
}