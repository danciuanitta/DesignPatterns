
namespace Mediator.Theory
{
    internal class ConcreteColleague1 : ICollegue
    {
        private IMediator _mediator;

        public ConcreteColleague1(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void GetMessage(string message)
        {
            Console.WriteLine($"Colleague1 got message: {message}");
        }

        public void Send(string message)
        {
            _mediator.SendMessage(message, this);
        }
    }
}
