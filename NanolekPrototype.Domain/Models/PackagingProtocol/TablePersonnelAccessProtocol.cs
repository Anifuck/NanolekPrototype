using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace NanolekPrototype.EntityModels.Models
{
    public class TablePersonnelAccessProtocol
    {
        public int Id { get; set; }
        public PackagingProtocol PackagingProtocol { get; set; }
        public int PackagingProtocolId { get; set; }
        public bool IsActive { get; set; }

        [DisplayName("№ Протокола")]
        public string ProtocolNumber { get; set; }
        [DisplayName("Дата протокола")]
        public DateTime ProtocolDate { get; set; }

    }
}