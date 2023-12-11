
namespace Decorator.Practice.Polly
{
    internal class ApiClientWithRetry : IApiClientWithRetry, IApiClient
    {
        private readonly IApiClient apiClient;

        public ApiClientWithRetry(IApiClient apiClient)
        {
            this.apiClient = apiClient;
        }

        public string GetResultFromApiCall()
        {
            return "Retry handler + " + apiClient.GetResultFromApiCall();
        }
    }
}
