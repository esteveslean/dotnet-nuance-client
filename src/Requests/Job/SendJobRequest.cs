using Dotnet.NuanceClient.Types;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Net.Http;

namespace Dotnet.NuanceClient.Requests.Job
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class SendJobRequest : RequestBase<JobReference>
    {
        public SendJobRequest()
           : base("/v4/jobs",  HttpMethod.Post)
        { }

        [JsonProperty(Required = Required.Always)]
        public string JobType { get; set; } = "batch_transcription";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CallbackUrl { get; set; }

        [JsonProperty(Required = Required.Always)]
        public string OperatingMode { get; set; } = "Fast";

        [JsonProperty(Required = Required.Always)]
        public Model Model { get; set; }

        [JsonProperty(Required = Required.Always)]
        public Channels Channels { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ClientData { get; set; }
    }
}
