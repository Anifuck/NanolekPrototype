using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using NanolekPrototype.EntityModels.Enums;

namespace NanolekPrototype.EntityModels.Models
{
    public class FormControlOfPrimaryPackaging: PackagingProtocolForm
    {
        [NotMapped]
        public override PackagingProtokolFormType Type =>
            PackagingProtokolFormType.ControlOfPrimaryPackaging;

        //Таблица «Контроль упаковки»:
        public ICollection<TablePackagingControl> PackagingControls { get; set; }
    }
}