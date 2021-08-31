using System;
using NanolekPrototype.EntityModels.Enums;
using NanolekPrototype.EntityModels.Models;
using NanolekPrototype.Models;

namespace NanolekPrototype.ViewModels
{
    public class EditPackagingProtocolViewModel
    {
        public long Id { get; set; }
        public string SerialNumber { get; set; }
        public User ResponsibleUserOOK { get; set; }
        public string StorageConditions { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime SellBy { get; set; }
        public string PackageNumber { get; set; }
        public User ResponsibleUserTLF { get; set; }
        public string TradeName { get; set; }
        public string SpecificationGP { get; set; }
        public string InternalCodeGP { get; set; }
        public PackagingProtocolStatus PackagingProtocolStatus { get; set; }
        public string CancellationReason { get; set; }
        public string NewResponsibleUserOOKGuid { get; set; }
        public string NewResponsibleUserTLFGuid { get; set; }
    }
}