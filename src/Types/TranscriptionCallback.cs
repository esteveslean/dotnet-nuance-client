using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;

namespace Dotnet.NuanceClient.Types
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class TranscriptionCallback
    {
        [JsonProperty(Required = Required.Always)]
        public string Status { get; set; }

        [JsonProperty(Required = Required.Always)]
        public Guid? Reference { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string OperatingMode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Channels Channels { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ClientData { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Statistics Statistics { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<object> Errors { get; set; }
    }
}
