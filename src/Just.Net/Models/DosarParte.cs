using System.Runtime.Serialization;

namespace Just.Net.Models
{
    [DataContract(Name = "DosarParte", Namespace = "portalquery.just.ro")]
    public class DosarParte
    {
        [DataMember(EmitDefaultValue = false, Name = "nume")]
        public string Nume { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "calitateParte", Order = 1)]
        public string CalitateParte { get; set; }
    }
}