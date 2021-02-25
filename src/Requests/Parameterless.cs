using System.Net.Http;

namespace Dotnet.NuanceClient.Requests
{
    public class Parameterless<TResult> : RequestBase<TResult>
    {
        public Parameterless(string methodName)
            : base(methodName)
        { }

        public Parameterless(string methodName, HttpMethod method)
            : base(methodName, method)
        { }
    }
}
