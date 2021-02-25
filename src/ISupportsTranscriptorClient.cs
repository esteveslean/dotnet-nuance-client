using Dotnet.NuanceClient.Types;
using System.Threading;
using System.Threading.Tasks;

namespace Dotnet.NuanceClient
{
    public interface ISupportsTranscriptorClient
    {
        string TranscriptorUrl { get; }

        /// <summary>
        /// Test the transcriptor engine
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns><c>TranscriberStatus</c> if transcriptor is running</returns>
        Task<TranscriberStatus> GetPingAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of all jobs in the system that are not completed, that is, jobs whose status is not COMPLETE,
        /// TRANSCRIBED, FAILED, and so on
        /// </summary>       
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        /// <returns><c>TranscriberJobs</c></returns>
        Task<TranscriberJobs> GetActiveJobsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of all jobs in the system, with completed jobs retained according to the config setting,
        /// resultConfiguration.retentionTime
        /// </summary>       
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
        /// <returns><c>TranscriberJobs</c></returns>
        Task<TranscriberJobs> GetJobsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Start request to perform transcriptions
        /// </summary>
        /// <param name="audioUrl">Where to fetch the audio recording for the channel in a pull request</param>
        /// <param name="operatingMode">The accuracy/speed setting for transcription</param>
        /// <param name="numSpeaker">The number of speakers in the audio recording, if known. This entry also affects the diarization process</param>
        /// <param name="diarize">Whether audio recordings will be split into individual speakers</param>
        /// <param name="languageModel">Locale code of the audio to transcribe or autodetect</param>
        /// <param name="clientData">One or more arbitrary key-value pairs, separated by commas</param>
        /// /// <param name="callbackUrl">The location of a web server that accepts POST commands from Transcription Engine containing job results in JSON format</param>
        /// <exception cref="System.IdentityModel.BadRequestException"></exception>
        Task<JobReference> StartAsync(
            string audioUrl,
            string operatingMode,
            int numSpeaker,
            bool diarize,
            string languageModel,
            object clientData,
            string callbackUrl = null,
            CancellationToken cancellationToken = default);
    }
}
