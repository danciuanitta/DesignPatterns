
namespace ChainOfResponsibility.Theory
{
    internal class ConcreteHandlerB : IHandler
    {
        private IHandler? _nextHandler;
        public void SetTheNextHandler(IHandler handler)
        {
            _nextHandler = handler;
        }
        public void Process(string request)
        {
            if (request.Equals("HandlerB"))
            {
                Console.WriteLine($"Request {request} processed by handler B");
                return;
            }

            _nextHandler?.Process(request);
        }
    }
}
