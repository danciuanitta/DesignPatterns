
namespace Mediator.Theory
{
    internal class ConcreteMediatorIMediator : IMediator
    {
        public ICollegue _collegue1;
        public ICollegue _collegue2;

        public ConcreteMediatorIMediator()
        {
            _collegue1 = new ConcreteColleague1(this);
            _collegue2 = new ConcreteColleague2(this);
        }

        public void SendMessage(string message, ICollegue collegue)
        {
            if (collegue == _collegue1)
            {
                _collegue1.GetMessage(message);
            }
            else
            {
                _collegue2.GetMessage(message);
            }
        }
    }
}
