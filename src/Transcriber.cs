using System;

namespace Dotnet.NuanceClient
{
    public class Transcriber : ITranscriber
    {        
        public ISupportsTranscriptorClient DefineUrl(string url)
        {
            url = url ?? throw new ArgumentNullException(nameof(url));

            if (!url.StartsWith("http"))
                throw new ArgumentException(
                    "Invalid format. A valid transcriptorUrl looks like \"http://localhost:8080\".",
                    nameof(url)
                );

            return new SupportsTranscriptorClient(url);
        }
    }
}
