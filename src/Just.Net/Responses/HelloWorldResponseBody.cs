using System.ComponentModel;
using System.Runtime.Serialization;

namespace Just.Net.Responses
{
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [DataContract(Namespace = "portalquery.just.ro")]
    internal class HelloWorldResponseBody
    {
        [DataMember(EmitDefaultValue = false, Order = 0)]
        public string HelloWorldResult;

        public HelloWorldResponseBody()
        {
        }

        public HelloWorldResponseBody(string HelloWorldResult)
        {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
}