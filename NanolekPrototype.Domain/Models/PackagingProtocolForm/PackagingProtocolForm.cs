using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class PackagingProtocolForm
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public Guid Guid { get; set; }
        [DisplayName("Статус")]
        public FormStatus Status { get; set; }
        public virtual PackagingProtokolFormType Type { get; set; }
        public PackagingProtocol PackagingProtocol { get; set; }
        [DisplayName("Примечание")]
        public string Note { get; set; }
    }
}