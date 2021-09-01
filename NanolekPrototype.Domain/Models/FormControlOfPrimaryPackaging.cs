using System.Collections;
using System.Collections.Generic;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormControlOfPrimaryPackaging
    {
        public int Id { get; set; }
        public PackagingProtocol PackagingProtocol { get; set; }
        public bool IsActive { get; set; }
        public FormStatus FormStatus { get; set; }

        //Таблица «Контроль упаковки»:
        public ICollection<PackagingControl> PackagingControls { get; set; }
    }
}