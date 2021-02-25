using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Dotnet.NuanceClient.Types
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class TranscriberQueue
    {
        public string Name { get; set; }
        public int Pending { get; set; }
        public int Processing { get; set; }
    }
}
