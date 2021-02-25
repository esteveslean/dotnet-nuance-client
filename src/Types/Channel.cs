using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Dotnet.NuanceClient.Types
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Channel
    {
        [JsonProperty(Required = Required.Always)]
        public string Url { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string Format { get; set; } = "audio/wave";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Diarize { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int NumSpeakers { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ResultFormat { get; set; } = "transcript";        

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Transcript> Transcript { get; set; }
    }
}
