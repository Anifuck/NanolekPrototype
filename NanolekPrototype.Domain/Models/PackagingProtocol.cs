using System;
using System.Collections;
using System.Collections.Generic;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class PackagingProtocol
    {
        public long Id { get; set; }
        public Guid Guid { get; set; }
        public string SerialNumber { get; set; }
        public User ResponsibleUserOOK { get; set; }
        public string StorageConditions { get; set; }
        public double ShelfLife { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime SellBy { get; set; }
        public string PackageNumber { get; set; }
        public User ResponsibleUserTLF { get; set; }
        public string TradeName { get; set; }
        public string SpecificationGP { get; set; }
        public string InternalCodeGP { get; set; }
        public PackagingProtocolStatus PackagingProtocolStatus { get; set; }
        public string CancellationReason { get; set; }
        public ICollection<FormReceptionAndMovementOfBulkProduct> FormReceptionAndMovementOfBulkProducts { get; set; }
    }
}