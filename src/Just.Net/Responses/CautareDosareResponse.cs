using System.ComponentModel;
using System.ServiceModel;

namespace Just.Net.Responses
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    internal class CautareDosareResponse
    {
        [MessageBodyMember(Name = "CautareDosareResponse", Namespace = "portalquery.just.ro", Order = 0)]
        public CautareDosareResponseBody Body;

        public CautareDosareResponse()
        {
        }

        public CautareDosareResponse(CautareDosareResponseBody Body)
        {
            this.Body = Body;
        }
    }
}