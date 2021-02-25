using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Dotnet.NuanceClient.Types
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class DomainLM
    {
        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }
    }
}
