namespace Mediator.Practice
{
    internal class ChatUser : IUser
    {
        private readonly ChatMediator _mediator;

        public string Name { get; }

        public ChatUser(ChatMediator mediator, string name)
        {
            _mediator = mediator;
            Name = name;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending message {message} from user {Name}");
            _mediator.SendMessage(Name, message);
        }

        public void ReceiveMessage(string senderName, string message)
        {
            Console.WriteLine($"User {Name} received message: {message} from sender {senderName}");
        }
    }
}
