using System.ComponentModel;
using System.ServiceModel;

namespace Just.Net.Responses
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    internal class CautareSedinteResponse
    {
        [MessageBodyMember(Name = "CautareSedinteResponse", Namespace = "portalquery.just.ro", Order = 0)]
        public CautareSedinteResponseBody Body;

        public CautareSedinteResponse()
        {
        }

        public CautareSedinteResponse(CautareSedinteResponseBody Body)
        {
            this.Body = Body;
        }
    }
}