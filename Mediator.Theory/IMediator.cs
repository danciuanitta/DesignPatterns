namespace Mediator.Theory
{
    internal interface IMediator
    {
        void SendMessage(string message, ICollegue collegue);
    }
}
