using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Just.Net.Models;

namespace Just.Net.Requests
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DataContract(Namespace = "portalquery.just.ro")]
    internal class CautareDosare2RequestBody
    {
        [DataMember(Order = 4)] public DateTime? dataStart;

        [DataMember(Order = 5)] public DateTime? dataStop;

        [DataMember(Order = 6)] public DateTime? dataUltimaModificareStart;

        [DataMember(Order = 7)] public DateTime? dataUltimaModificareStop;

        [DataMember(Order = 3)] public Institutie? institutie;

        [DataMember(EmitDefaultValue = false, Order = 0)]
        public string numarDosar;

        [DataMember(EmitDefaultValue = false, Order = 2)]
        public string numeParte;

        [DataMember(EmitDefaultValue = false, Order = 1)]
        public string obiectDosar;

        public CautareDosare2RequestBody()
        {
        }

        public CautareDosare2RequestBody(string numarDosar, string obiectDosar, string numeParte,
            Institutie? institutie, DateTime? dataStart, DateTime? dataStop, DateTime? dataUltimaModificareStart,
            DateTime? dataUltimaModificareStop)
        {
            this.numarDosar = numarDosar;
            this.obiectDosar = obiectDosar;
            this.numeParte = numeParte;
            this.institutie = institutie;
            this.dataStart = dataStart;
            this.dataStop = dataStop;
            this.dataUltimaModificareStart = dataUltimaModificareStart;
            this.dataUltimaModificareStop = dataUltimaModificareStop;
        }
    }
}