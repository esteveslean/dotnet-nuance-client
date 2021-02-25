using Dotnet.NuanceClient.Requests.Abstractions;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace Dotnet.NuanceClient.Requests
{
    public abstract class RequestBase<TResponse> : IRequest<TResponse>
    {
        [JsonIgnore]
        public HttpMethod Method { get; }

        [JsonIgnore]
        public string MethodName { get; protected set; }

        protected RequestBase(string methodName, HttpMethod method)
        {
            MethodName = methodName;
            Method = method;
        }

        protected RequestBase(string methodName) {
            MethodName = methodName;
            Method = HttpMethod.Get;
        }

        public virtual HttpContent ToHttpContent()
        {
            string payload = JsonConvert.SerializeObject(this);
            return new StringContent(payload, Encoding.UTF8, "application/json");
        }
    }
}
