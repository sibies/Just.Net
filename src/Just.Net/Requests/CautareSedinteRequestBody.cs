using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Just.Net.Models;

namespace Just.Net.Requests
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DataContract(Namespace = "portalquery.just.ro")]
    internal class CautareSedinteRequestBody
    {
        [DataMember(Order = 0)] public DateTime dataSedinta;

        [DataMember(Order = 1)] public Institutie institutie;

        public CautareSedinteRequestBody()
        {
        }

        public CautareSedinteRequestBody(DateTime dataSedinta, Institutie institutie)
        {
            this.dataSedinta = dataSedinta;
            this.institutie = institutie;
        }
    }
}