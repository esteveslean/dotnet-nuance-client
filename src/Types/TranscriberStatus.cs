using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Dotnet.NuanceClient.Types
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class TranscriberStatus
    {
        public string Status { get; set; }
        public bool StandAlone { get; set; }
        public string NodeId { get; set; }
        public string EngineStatus { get; set; }        
        public List<TranscriberQueue> Queues { get; set; }
        public List<string> Jobs { get; set; }
    }

   
}
