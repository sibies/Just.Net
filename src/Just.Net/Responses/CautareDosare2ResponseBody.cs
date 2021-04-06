using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Just.Net.Models;

namespace Just.Net.Responses
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DataContract(Namespace = "portalquery.just.ro")]
    internal class CautareDosare2ResponseBody
    {
        [DataMember(EmitDefaultValue = false, Order = 0)]
        public List<Dosar> CautareDosare2Result;

        public CautareDosare2ResponseBody()
        {
        }

        public CautareDosare2ResponseBody(List<Dosar> CautareDosare2Result)
        {
            this.CautareDosare2Result = CautareDosare2Result;
        }
    }
}