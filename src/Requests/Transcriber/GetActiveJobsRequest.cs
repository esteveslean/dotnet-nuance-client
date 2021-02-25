using Dotnet.NuanceClient.Types;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Dotnet.NuanceClient.Requests.Transcriber
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetActiveJobsRequest : Parameterless<TranscriberJobs>
    {
        public GetActiveJobsRequest()
            : base("/v4/jobs/active")
        { }
    }
}
