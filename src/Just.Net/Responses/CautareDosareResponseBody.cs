using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Just.Net.Models;

namespace Just.Net.Responses
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DataContract(Namespace = "portalquery.just.ro")]
    internal class CautareDosareResponseBody
    {
        [DataMember(EmitDefaultValue = false, Order = 0)]
        public List<Dosar> CautareDosareResult;

        public CautareDosareResponseBody()
        {
        }

        public CautareDosareResponseBody(List<Dosar> CautareDosareResult)
        {
            this.CautareDosareResult = CautareDosareResult;
        }
    }
}