﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace NanolekPrototype.EntityModels.Models
{
    public class User : IdentityUser<int>
    {
        [DisplayName("Фио")]
        public string FullName { get; set; }
        [DisplayName("Должность")]
        public string Position { get; set; }
        public ICollection<PackagingProtocol> OOK { get; set; }
        public ICollection<PackagingProtocol> TLF { get; set; }

        public ICollection<FormReceptionAndMovementOfBulkProduct> FormReceptionAndMovementOfBulkProductCalcers { get; set; }
        public ICollection<FormReceptionAndMovementOfBulkProduct> FormReceptionAndMovementOfBulkProductCheckers { get; set; }
        public ICollection<FormReceptionAndMovementOfBulkProduct> FormReceptionAndMovementOfBulkProductShiftMasters { get; set; }
        public ICollection<FormReceptionAndMovementOfPackingMaterial> FormReceptionAndMovementOfPackingMaterialCalcers
        {
            get;
            set;
        }
        public ICollection<FormReceptionAndMovementOfPackingMaterial> FormReceptionAndMovementOfPackingMaterialCheckers
        {
            get;
            set;
        }
        public ICollection<FormReceptionAndMovementOfPackingMaterial> FormReceptionAndMovementOfPackingMaterialShiftMasters
        {
            get;
            set;
        }
        public ICollection<TableReceptionOfMaterial> TableReceptionOfMaterialShiftMasters { get; set; }
        public ICollection<TableSettingUpTechnologicalEquipment> TableSettingUpTechnologicalEquipmentServiceTechnicians { get; set; }
        public ICollection<TableVerificationAction> TableVerificationActionTaskMasters { get; set; }
    }
}