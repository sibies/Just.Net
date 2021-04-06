using System.ComponentModel;
using System.ServiceModel;

namespace Just.Net.Requests
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    internal class CautareSedinteRequest
    {
        [MessageBodyMember(Name = "CautareSedinte", Namespace = "portalquery.just.ro", Order = 0)]
        public CautareSedinteRequestBody Body;

        public CautareSedinteRequest()
        {
        }

        public CautareSedinteRequest(CautareSedinteRequestBody Body)
        {
            this.Body = Body;
        }
    }
}