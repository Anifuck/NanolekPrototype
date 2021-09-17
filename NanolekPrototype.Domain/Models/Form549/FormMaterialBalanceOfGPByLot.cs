using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    /// <summary>
    ///	Материальный баланс ГП по серии
    /// </summary>
    [Serializable()]
    public class FormMaterialBalanceOfGPByLot : PackagingProtocolForm
    {
        /// <summary>
        /// Тип
        /// </summary>
        [NotMapped]
        [DisplayName("Тип")]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.MaterialBalanceOfGPByLot;

        //Основное
        /// <summary>
        /// Дата начала упаковки
        /// </summary>
        [DisplayName("Дата начала упаковки")]
        public DateTime StartDateOfPacking { get; set; }
        /// <summary>
        /// Дата окончания упаковки
        /// </summary>
        [DisplayName("Дата окончания упаковки")]
        public DateTime FinishDateOfPacking { get; set; }
        /// <summary>
        /// Мастер смены (ФИО)
        /// </summary>
        [DisplayName("Мастер смены (ФИО)")]
        public User ShiftMaster { get; set; }
        public int? ShiftMasterId { get; set; }
        /// <summary>
        /// Мастер смены (Дата)
        /// </summary>
        [DisplayName("Мастер смены (Дата)")]
        public DateTime ShiftMasterDate { get; set; }
        /// <summary>
        /// Расчет произвел (ФИО)
        /// </summary>
        [DisplayName("Расчет произвел (ФИО)")]
        [XmlIgnore]
        public User CalcedByUser { get; set; }
        public int? CalcedByUserId { get; set; }
        /// <summary>
        /// Расчет произвел (Дата)
        /// </summary>
        [DisplayName("Расчет произвел (Дата)")]
        public DateTime CalcedByUserDate { get; set; }
        /// <summary>
        /// Расчет проверил (ФИО)
        /// </summary>
        [DisplayName("Расчет проверил (ФИО)")]
        [XmlIgnore]
        public User CheckedByUser { get; set; }
        public int? CheckedByUserId { get; set; }
        /// <summary>
        /// Расчет проверил (Дата)
        /// </summary>
        [DisplayName("Расчет проверил (Дата)")]
        public DateTime CheckedByUserDate { get; set; }
        /// <summary>
        /// Проверку ПУ осуществил (ФИО)
        /// </summary>
        [DisplayName("Проверку ПУ осуществил (ФИО)")]
        [XmlIgnore]
        public User CheckedPUByUser { get; set; }
        public int? CheckedPUByUserId { get; set; }
        /// <summary>
        /// Проверку ПУ осуществил (Дата)
        /// </summary>
        [DisplayName("Проверку ПУ осуществил (Дата)")]
        public DateTime CheckedPUByUserDate { get; set; }

        //Группа «Итог упаковки»:
        /// <summary>
        /// Выход в упаковках
        /// </summary>
        [DisplayName("Выход в упаковках")]
        public int PackagesCount { get; set; }
        /// <summary>
        /// Выход по регламенту
        /// </summary>
        [DisplayName("Выход по регламенту")]
        public ExitAccordingToTheRegulations ExitAccordingToTheRegulations { get; set; }
        /// <summary>
        /// Соответствует
        /// </summary>
        [DisplayName("Соответствует")]
        public bool IsCompliant { get; set; }

        //Группа «Наблюдения»:
        /// <summary>
        /// Наблюдения
        /// </summary>
        [DisplayName("Наблюдения")]
        public string Observations { get; set; }
        /// <summary>
        /// Мастер смены/бригадир
        /// </summary>
        [DisplayName("Мастер смены/бригадир")]
        [XmlIgnore]
        public User TaskMaster { get; set; }
        public int? TaskMasterId { get; set; }
        /// <summary>
        /// Дата
        /// </summary>
        [DisplayName("Дата")]
        public DateTime Date { get; set; }
    }
}