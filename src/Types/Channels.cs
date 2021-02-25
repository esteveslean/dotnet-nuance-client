using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Dotnet.NuanceClient.Types
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Channels
    {
        [JsonProperty(Required = Required.Always)]
        public Channel Channel { get; set; }
    }
}
