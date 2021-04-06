using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Just.Net.Models
{
    [DataContract(Name="Dosar", Namespace="portalquery.just.ro")]
    public class Dosar
    {
        [DataMember(EmitDefaultValue=false, Name = "parti", Order = 0)]
        public List<DosarParte> Parti { get; set; }
        
        [DataMember(EmitDefaultValue=false, Name = "sedinte", Order = 1)]
        public List<DosarSedinta> Sedinte { get; set; }

        [DataMember(EmitDefaultValue=false, Name = "caiAtac", Order=2)]
        public List<DosarCaleAtac> CaiAtac { get; set; }

        [DataMember(EmitDefaultValue=false, Name = "numar", Order=3)]
        public string Numar { get; set; }

        [DataMember(EmitDefaultValue=false, Name = "numarVechi", Order=4)]
        public string NumarVechi { get; set; }

        [DataMember(IsRequired=true, Name = "data", Order=5)]
        public DateTime Data { get; set; }

        [DataMember(IsRequired=true, Name = "institutie", Order=6)]
        public Institutie Institutie { get; set; }

        [DataMember(EmitDefaultValue=false, Name = "departament", Order=7)]
        public string Departament { get; set; }

        [DataMember(IsRequired=true, Name = "categorieCaz", Order=8)]
        public CategorieCaz? CategorieCaz { get; set; }

        [DataMember(IsRequired=true, Name = "stadiuProcesual", Order=9)]
        public StadiuProcesual? StadiuProcesual { get; set; }

        [DataMember(EmitDefaultValue=false, Name = "obiect", Order=10)]
        public string Obiect { get; set; }

        [DataMember(IsRequired=true, Name = "dataModificare", Order=11)]
        public DateTime DataModificare { get; set; }

        [DataMember(EmitDefaultValue=false, Name = "categorieCazNume", Order=12)]
        public string CategorieCazNume { get; set; }

        [DataMember(EmitDefaultValue=false, Name = "stadiuProcesualNume", Order=13)]
        public string StadiuProcesualNume { get; set; }
    }
}