using System;
using System.Runtime.Serialization;

namespace Just.Net.Models
{
    [DataContract(Name = "DosarCaleAtac", Namespace = "portalquery.just.ro")]
    public class DosarCaleAtac
    {
        [DataMember(IsRequired = true, Name = "dataDeclarare")]
        public DateTime? DataDeclarare { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "parteDeclaratoare")]
        public string ParteDeclaratoare { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "tipCaleAtac")]
        public string TipCaleAtac { get; set; }
    }
}