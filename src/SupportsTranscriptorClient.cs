using Dotnet.NuanceClient.Requests.Abstractions;
using Dotnet.NuanceClient.Requests.Job;
using Dotnet.NuanceClient.Requests.Transcriber;
using Dotnet.NuanceClient.Types;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Dotnet.NuanceClient
{
    public class SupportsTranscriptorClient : ISupportsTranscriptorClient
    {
        public string TranscriptorUrl { get; }

        private readonly HttpClient _httpClient;

        public SupportsTranscriptorClient(string url)
        {
            TranscriptorUrl = url;
            _httpClient = new HttpClient();
        }

        private async Task<TResponse> InvokeRequestAsync<TResponse>(
            IRequest<TResponse> request,
            CancellationToken cancellationToken = default)
        {
            string url = TranscriptorUrl + request.MethodName;

            HttpResponseMessage httpResponse;

            httpResponse = await _httpClient.SendAsync(new HttpRequestMessage(request.Method, url)
            {
                Content = request.ToHttpContent()
            }, cancellationToken);

            return JsonConvert.DeserializeObject<TResponse>(await httpResponse.Content.ReadAsStringAsync(cancellationToken));
        }

        public async Task<TranscriberStatus> GetPingAsync(CancellationToken cancellationToken = default)
            => await InvokeRequestAsync(new GetTranscriberStatusRequest(), cancellationToken);

        public async Task<TranscriberJobs> GetActiveJobsAsync(CancellationToken cancellationToken = default)
            => await InvokeRequestAsync(new GetActiveJobsRequest(), cancellationToken);

        public async Task<TranscriberJobs> GetJobsAsync(CancellationToken cancellationToken = default)
            => await InvokeRequestAsync(new GetJobsRequest(), cancellationToken);  
        
        public async Task<JobReference> StartAsync(
            string audioUrl,
            string operatingMode,
            int numSpeaker,
            bool diarize,
            string languageModel,
            object clientData,
            string callbackUrl = null,
            CancellationToken cancellationToken = default
            ) => await InvokeRequestAsync(new SendJobRequest
            {
                CallbackUrl = callbackUrl,
                OperatingMode = operatingMode,
                ClientData = clientData,
                Channels = new Channels
                {
                    Channel = new Channel
                    {
                        Url = audioUrl,
                        NumSpeakers = numSpeaker,
                        Diarize = diarize
                    }
                },
                Model = new Model
                {
                    Name = languageModel
                }
            }, cancellationToken);
    }
}
