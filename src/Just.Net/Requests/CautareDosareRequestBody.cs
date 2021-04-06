using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Just.Net.Models;

namespace Just.Net.Requests
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DataContract(Namespace = "portalquery.just.ro")]
    internal class CautareDosareRequestBody
    {
        [DataMember(Order = 4)] public DateTime? dataStart;

        [DataMember(Order = 5)] public DateTime? dataStop;

        [DataMember(Order = 3)] public Institutie? institutie;

        [DataMember(EmitDefaultValue = false, Order = 0)]
        public string numarDosar;

        [DataMember(EmitDefaultValue = false, Order = 2)]
        public string numeParte;

        [DataMember(EmitDefaultValue = false, Order = 1)]
        public string obiectDosar;

        public CautareDosareRequestBody()
        {
        }

        public CautareDosareRequestBody(string numarDosar, string obiectDosar, string numeParte, Institutie? institutie,
            DateTime? dataStart, DateTime? dataStop)
        {
            this.numarDosar = numarDosar;
            this.obiectDosar = obiectDosar;
            this.numeParte = numeParte;
            this.institutie = institutie;
            this.dataStart = dataStart;
            this.dataStop = dataStop;
        }
    }
}