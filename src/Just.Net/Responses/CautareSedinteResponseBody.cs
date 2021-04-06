using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Just.Net.Models;

namespace Just.Net.Responses
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DataContract(Namespace = "portalquery.just.ro")]
    internal class CautareSedinteResponseBody
    {
        [DataMember(EmitDefaultValue = false, Order = 0)]
        public List<Sedinta> CautareSedinteResult;

        public CautareSedinteResponseBody()
        {
        }

        public CautareSedinteResponseBody(List<Sedinta> CautareSedinteResult)
        {
            this.CautareSedinteResult = CautareSedinteResult;
        }
    }
}