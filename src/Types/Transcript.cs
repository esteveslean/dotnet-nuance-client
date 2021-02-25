using System.Collections.Generic;

namespace Dotnet.NuanceClient.Types
{
    public class Transcript
    {
        public string Text { get; set; }
        public string Speaker { get; set; }
        public double Start { get; set; }
        public double End { get; set; }
        public List<Alignment> Alignment { get; set; }
    }
}