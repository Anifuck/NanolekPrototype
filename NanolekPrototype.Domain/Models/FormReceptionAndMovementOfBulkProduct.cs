using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormReceptionAndMovementOfBulkProduct : PackagingProtocolForm
    {
        [NotMapped]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.ReceptionAndMovementOfBulkProduct;


        public int InternalCodeOfMaterial { get; set; }
        public string Specification { get; set; }
        public User CalcedByUser { get; set; }
        public DateTime CalcedByUserDate { get; set; }
        public User CheckedByUser { get; set; }
        public DateTime CheckedByUserDate { get; set; }

        /// <summary>
        /// Дата
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Получено ПрП по документации, кг
        /// </summary>
        public int GetPRP { get; set; }

        public string PartSAP { get; set; }
        public bool IsCorrespondToControlIndicators { get; set; }
        public bool IsCorrespondToShelfLife { get; set; }
        public User ShiftMaster { get; set; }


        public int EntredIntoGPPackages { get; set; }
        public int EntredIntoGPUnits { get; set; }
        public int GarbageUnits { get; set; }
        public int DefectFirstPackageUnits { get; set; }
        public int SampleSelectionUnits { get; set; }
        public int GarbageSecondPackageUnits { get; set; }


        public ICollection<MovementOfBulkProduct> MovementOfBulkProducts { get; set; }
    }
}