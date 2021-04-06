using System.ServiceModel;
using System.Threading.Tasks;
using Just.Net.Requests;
using Just.Net.Responses;

namespace Just.Net.InternalClient
{
    [ServiceContract(Namespace = "portalquery.just.ro", ConfigurationName = "PortalWs.QuerySoap")]
    internal interface QuerySoap
    {
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace portalquery.just.ro is not marked nillable
        [OperationContract(Action = "portalquery.just.ro/HelloWorld", ReplyAction = "*")]
        HelloWorldResponse HelloWorld(HelloWorldRequest request);

        [OperationContract(Action = "portalquery.just.ro/HelloWorld", ReplyAction = "*")]
        Task<HelloWorldResponse> HelloWorldAsync(HelloWorldRequest request);

        // CODEGEN: Generating message contract since element name numarDosar from namespace portalquery.just.ro is not marked nillable
        [OperationContract(Action = "portalquery.just.ro/CautareDosare", ReplyAction = "*")]
        CautareDosareResponse CautareDosare(CautareDosareRequest request);

        [OperationContract(Action = "portalquery.just.ro/CautareDosare", ReplyAction = "*")]
        Task<CautareDosareResponse> CautareDosareAsync(CautareDosareRequest request);

        // CODEGEN: Generating message contract since element name numarDosar from namespace portalquery.just.ro is not marked nillable
        [OperationContract(Action = "portalquery.just.ro/CautareDosare2", ReplyAction = "*")]
        CautareDosare2Response CautareDosare2(CautareDosare2Request request);

        [OperationContract(Action = "portalquery.just.ro/CautareDosare2", ReplyAction = "*")]
        Task<CautareDosare2Response> CautareDosare2Async(CautareDosare2Request request);

        // CODEGEN: Generating message contract since element name CautareSedinteResult from namespace portalquery.just.ro is not marked nillable
        [OperationContract(Action = "portalquery.just.ro/CautareSedinte", ReplyAction = "*")]
        CautareSedinteResponse CautareSedinte(CautareSedinteRequest request);

        [OperationContract(Action = "portalquery.just.ro/CautareSedinte", ReplyAction = "*")]
        Task<CautareSedinteResponse> CautareSedinteAsync(CautareSedinteRequest request);
    }
}