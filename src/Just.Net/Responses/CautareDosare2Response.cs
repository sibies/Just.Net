using System.ComponentModel;
using System.ServiceModel;

namespace Just.Net.Responses
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    internal class CautareDosare2Response
    {
        [MessageBodyMember(Name = "CautareDosare2Response", Namespace = "portalquery.just.ro", Order = 0)]
        public CautareDosare2ResponseBody Body;

        public CautareDosare2Response()
        {
        }

        public CautareDosare2Response(CautareDosare2ResponseBody Body)
        {
            this.Body = Body;
        }
    }
}