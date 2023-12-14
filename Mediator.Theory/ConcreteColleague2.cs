namespace Mediator.Theory
{
    internal class ConcreteColleague2 : ICollegue
    {
        private IMediator _mediator;

        public ConcreteColleague2(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void GetMessage(string message)
        {
            Console.WriteLine($"Colleague2 got message: {message}");
        }

        public void Send(string message)
        {
            _mediator.SendMessage(message, this);
        }
    }
}
