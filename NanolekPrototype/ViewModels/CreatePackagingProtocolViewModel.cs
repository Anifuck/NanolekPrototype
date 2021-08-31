using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using NanolekPrototype.Models;

namespace NanolekPrototype.ViewModels
{
    public class CreatePackagingProtocolViewModel
    {
        public string SerialNumber { get; set; }
        public string ResponsibleUserOOKGuid { get; set; }
        public string StorageConditions { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime SellBy { get; set; }
        public string PackageNumber { get; set; }
        public String ResponsibleUserTLFGuid { get; set; }
        public string TradeName { get; set; }
        public string SpecificationGP { get; set; }
        public string InternalCodeGP { get; set; }
        public Status Status { get; set; } = Status.InWork;
        public string CancellationReason { get; set; }
    }
}