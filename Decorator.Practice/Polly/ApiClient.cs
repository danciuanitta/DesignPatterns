
namespace Decorator.Practice.Polly
{
    internal class ApiClient : IApiClient
    {
        public string GetResultFromApiCall()
        {
            return "This is from initial object";
        }
    }
}
