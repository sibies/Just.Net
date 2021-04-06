using System;
using System.Runtime.Serialization;

namespace Just.Net.Models
{
    [DataContract(Name="DosarSedinta", Namespace="portalquery.just.ro")]
    public class DosarSedinta
    {
        [DataMember(EmitDefaultValue=false, Name = "complet", Order = 0)]
        public string Complet { get; set; }

        [DataMember(IsRequired=true, Name = "data", Order = 1)]
        public DateTime Data { get; set; }

        [DataMember(EmitDefaultValue=false, Name = "ora", Order = 2)]
        public string Ora { get; set; }

        [DataMember(EmitDefaultValue=false, Name = "solutie", Order = 3)]
        public string Solutie { get; set; }

        [DataMember(EmitDefaultValue=false, Name = "solutieSumar", Order = 4)]
        public string SolutieSumar { get; set; }

        [DataMember(IsRequired=true, Name = "dataPronuntare", Order=5)]
        public DateTime? DataPronuntare { get; set; }

        [DataMember(IsRequired=true, Name = "documentSedinta", Order=6)]
        public DocumentSedinta? DocumentSedinta { get; set; }

        [DataMember(EmitDefaultValue=false, Name = "numarDocument", Order=7)]
        public string NumarDocument { get; set; }

        [DataMember(IsRequired=true, Name = "dataDocument", Order=8)]
        public DateTime? DataDocument { get; set; }
    }
}