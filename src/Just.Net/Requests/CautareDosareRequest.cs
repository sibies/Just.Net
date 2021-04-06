using System.ComponentModel;
using System.ServiceModel;

namespace Just.Net.Requests
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    internal class CautareDosareRequest
    {
        [MessageBodyMember(Name = "CautareDosare", Namespace = "portalquery.just.ro", Order = 0)]
        public CautareDosareRequestBody Body;

        public CautareDosareRequest()
        {
        }

        public CautareDosareRequest(CautareDosareRequestBody Body)
        {
            this.Body = Body;
        }
    }
}