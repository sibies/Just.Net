using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Just.Net.Models
{
    [DataContract(Name = "Sedinta", Namespace = "portalquery.just.ro")]
    public class Sedinta
    {
        [DataMember(EmitDefaultValue = false, Name = "departament", Order = 0)] 
        public string Departament { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "complet", Order = 1)]
        public string Complet { get; set; }

        [DataMember(IsRequired = true, Name = "data", Order = 2)]
        public DateTime Data { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "ora", Order = 3)]
        public string Ora { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "dosare", Order = 4)]
        public List<SedintaDosar> Dosare { get; set; }
    }
}