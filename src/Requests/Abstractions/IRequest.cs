using System.Net.Http;

namespace Dotnet.NuanceClient.Requests.Abstractions
{
    public interface IRequest<TResponse>
    {
        HttpMethod Method { get; }
        string MethodName { get; }
        HttpContent ToHttpContent();
    }
}
