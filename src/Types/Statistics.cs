using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Dotnet.NuanceClient.Types
{
    [JsonObject(MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Statistics
    {
        public int ContentFetchTime { get; set; }
        public double AudioLength { get; set; }
        public int AudioChannels { get; set; }
        public int AudioAnalysisTime { get; set; }
        public int SegmentationTime { get; set; }
        public int TranscriptionTime { get; set; }
        public int DiarizationTime { get; set; }
        public int MusicDetectionTime { get; set; }
        public int MergeTime { get; set; }
        public int FormattingTime { get; set; }
        public int ExecutionTime { get; set; }
        public int RequestProcessingTime { get; set; }
        public int JobPreparationTime { get; set; }
    }
}