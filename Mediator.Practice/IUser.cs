
namespace Mediator.Practice
{
    public interface IUser
    {
        public string Name { get; }
        void SendMessage(string message);
        void ReceiveMessage(string senderName, string message);
    }
}
