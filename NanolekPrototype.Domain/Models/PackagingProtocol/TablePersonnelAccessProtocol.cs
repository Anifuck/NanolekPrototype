using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NanolekPrototype.EntityModels.Models
{
    public class TablePersonnelAccessProtocol
    {
        public int Id { get; set; }
        public PackagingProtocol PackagingProtocol { get; set; }
        public int PackagingProtocolId { get; set; }
        public bool IsActive { get; set; }


        public string ProtocolNumber { get; set; }
        public DateTime ProtocolDate { get; set; }

    }
}