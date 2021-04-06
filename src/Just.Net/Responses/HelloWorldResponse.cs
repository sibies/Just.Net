using System.ComponentModel;
using System.ServiceModel;

namespace Just.Net.Responses
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    internal class HelloWorldResponse
    {
        [MessageBodyMember(Name = "HelloWorldResponse", Namespace = "portalquery.just.ro", Order = 0)]
        public HelloWorldResponseBody Body;

        public HelloWorldResponse()
        {
        }

        public HelloWorldResponse(HelloWorldResponseBody Body)
        {
            this.Body = Body;
        }
    }
}