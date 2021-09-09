using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormMaterialBalanceOfGPByLot : PackagingProtocolForm
    {
        [NotMapped]
        [DisplayName("Тип")]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.MaterialBalanceOfGPByLot;

        //Основное
        [DisplayName("Дата начала упаковки")]
        public DateTime StartDateOfPacking { get; set; }
        [DisplayName("Дата окончания упаковки")]
        public DateTime FinishDateOfPacking { get; set; }
        [DisplayName("Мастер смены (ФИО)")]
        public User ShiftMaster { get; set; }
        public int? ShiftMasterId { get; set; }
        [DisplayName("Мастер смены (Дата)")]
        public DateTime ShiftMasterDate { get; set; }
        [DisplayName("Расчет произвел (ФИО)")]
        public User CalcedByUser { get; set; }
        public int? CalcedByUserId { get; set; }
        [DisplayName("Расчет произвел (Дата)")]
        public DateTime CalcedByUserDate { get; set; }
        [DisplayName("Расчет проверил (ФИО)")]
        public User CheckedByUser { get; set; }
        public int? CheckedByUserId { get; set; }
        [DisplayName("Расчет проверил (Дата)")]
        public DateTime CheckedByUserDate { get; set; }
        [DisplayName("Проверку ПУ осуществил (ФИО)")]
        public User CheckedPUByUser { get; set; }
        public int? CheckedPUByUserId { get; set; }
        [DisplayName("Проверку ПУ осуществил (Дата)")]
        public DateTime CheckedPUByUserDate { get; set; }

        //Группа «Итог упаковки»:
        [DisplayName("Выход в упаковках")]
        public int PackagesCount { get; set; }
        [DisplayName("Выход по регламенту")]
        public ExitAccordingToTheRegulations ExitAccordingToTheRegulations { get; set; }
        [DisplayName("Соответствует")]
        public bool IsCompliant { get; set; }

        //Группа «Наблюдения»:
        [DisplayName("Наблюдения")]
        public string Observations { get; set; }
        [DisplayName("Мастер смены/бригадир")]
        public User TaskMaster { get; set; }
        public int? TaskMasterId { get; set; }
        [DisplayName("Дата")]
        public DateTime Date { get; set; }
    }
}