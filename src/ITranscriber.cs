namespace Dotnet.NuanceClient
{
    public interface ITranscriber
    {
        /// <summary>
        /// Set Transcritor Engine identifier URL
        /// </summary>
        ISupportsTranscriptorClient DefineUrl(string transcriptorUrl);       
    }
}
