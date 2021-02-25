using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;

namespace Dotnet.NuanceClient.Types
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class TranscriberJobs
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Guid> Jobs { get; set; }
    }
}
