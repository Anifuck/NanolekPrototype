using System;
using Microsoft.AspNetCore.Identity;

namespace NanolekPrototype.Models
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
        public Status Status { get; set; } = Status.InWork;
        public string CancellationReason { get; set; }

    }

    public enum Status
    {
        InWork,
        Completed,
        Cancelled,
    }

}