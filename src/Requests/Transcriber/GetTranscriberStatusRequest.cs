using Dotnet.NuanceClient.Types;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Dotnet.NuanceClient.Requests.Transcriber
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetTranscriberStatusRequest : Parameterless<TranscriberStatus>
    {
        public GetTranscriberStatusRequest()
            : base("/v4/ping")
        { }
    }
}
