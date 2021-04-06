using System.ComponentModel;
using System.ServiceModel;

namespace Just.Net.Requests
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    internal class CautareDosare2Request
    {
        [MessageBodyMember(Name = "CautareDosare2", Namespace = "portalquery.just.ro", Order = 0)]
        public CautareDosare2RequestBody Body;

        public CautareDosare2Request()
        {
        }

        public CautareDosare2Request(CautareDosare2RequestBody Body)
        {
            this.Body = Body;
        }
    }
}