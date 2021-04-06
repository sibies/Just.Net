using System.ComponentModel;
using System.ServiceModel;

namespace Just.Net.Requests
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    internal class HelloWorldRequest
    {
        [MessageBodyMember(Name = "HelloWorld", Namespace = "portalquery.just.ro", Order = 0)]
        public HelloWorldRequestBody Body;

        public HelloWorldRequest()
        {
        }

        public HelloWorldRequest(HelloWorldRequestBody Body)
        {
            this.Body = Body;
        }
    }
}