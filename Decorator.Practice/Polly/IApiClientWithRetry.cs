namespace Decorator.Practice.Polly
{
    internal interface IApiClientWithRetry
    {
        string GetResultFromApiCall();
    }
}
