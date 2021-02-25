using System.Threading;
using System.Threading.Tasks;

namespace Dotnet.NuanceClient.Requests.Abstractions
{
    public interface IRequestService
    {
        Task<TResponse> InvokeAsync<TResponse>(
            IRequest<TResponse> request,
            CancellationToken cancellationToken = default);
    }
}
