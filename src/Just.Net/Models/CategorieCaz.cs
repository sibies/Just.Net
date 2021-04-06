using System.Runtime.Serialization;

namespace Just.Net.Models
{
    
    [DataContract(Name="CategorieCaz", Namespace="portalquery.just.ro")]
    public enum CategorieCaz
    {
        
        [EnumMember]
        Penal = 0,
        
        [EnumMember]
        Civil = 1,
        
        [EnumMember]
        Litigiicuprofesionistii = 2,
        
        [EnumMember]
        Contenciosadministrativsifiscal = 3,
        
        [EnumMember]
        Minorisifamilie = 4,
        
        [EnumMember]
        Litigiidemunca = 5,
        
        [EnumMember]
        Altematerii = 6,
        
        [EnumMember]
        Asigurarisociale = 7,
        
        [EnumMember]
        Faliment = 8,
        
        [EnumMember]
        ProprietateIntelectuala = 9,
        
        [EnumMember]
        Dreptmaritimsifluvial = 10,
        
        [EnumMember]
        Insolventapersoaneifizice = 11,
    }
}