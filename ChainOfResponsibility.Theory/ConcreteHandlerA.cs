namespace ChainOfResponsibility.Theory
{
    internal class ConcreteHandlerA : IHandler
    {
        private IHandler? _nextHandler;

        public void SetTheNextHandler(IHandler handler)
        {
            _nextHandler = handler;
        }

        public void Process(string request)
        {
            if (request.Equals("HandlerA"))
            {
                Console.WriteLine($"Request {request} processed by handler A");
                return;

            }
            
            _nextHandler?.Process(request);
        }
    }
}
