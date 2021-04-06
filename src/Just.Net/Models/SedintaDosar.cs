using System;
using System.Runtime.Serialization;

namespace Just.Net.Models
{
    [DataContract(Name = "SedintaDosar", Namespace = "portalquery.just.ro")]
    public class SedintaDosar
    {
        [DataMember(EmitDefaultValue = false, Name = "numar", Order = 0)] 
        public string Numar { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "numar_vechi", Order = 1)] 
        public string NumarVechi { get; set; }

        [DataMember(IsRequired = true, Name = "data", Order = 2)]
        public DateTime Data { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "ora", Order = 3)]
        public string Ora { get; set; }

        [DataMember(IsRequired = true, Name = "categorieCaz", Order = 4)]
        public CategorieCaz? CategorieCaz { get; set; }

        [DataMember(IsRequired = true, Name = "stadiuProcesual", Order = 5)]
        public StadiuProcesual? StadiuProcesual { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "categorieCazNume", Order = 6)]
        public string CategorieCazNume { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "stadiuProcesualNume", Order = 7)]
        public string StadiuProcesualNume { get; set; }
    }
}