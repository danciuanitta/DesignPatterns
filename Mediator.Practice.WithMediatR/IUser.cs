namespace Mediator.Practice.WithMediatR
{
    public interface IUser
    {
        public string Name { get; }
        Task SendMessage(string message);
        Task ReceiveMessage(string senderName, string message);
    }
}
