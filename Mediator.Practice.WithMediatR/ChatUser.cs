using MediatR;

namespace Mediator.Practice.WithMediatR
{
    public sealed class ChatUser : IUser
    {
        private readonly IMediator _mediator;

        public string Name { get; }

        public ChatUser(IMediator mediator, string name)
        {
            _mediator = mediator;
            this.Name = name;
        }

        public async Task SendMessage(string message)
        {
            Console.WriteLine($"Sending message {message} from user {Name}");
            var messageToSend = new ChatMessage()
            {
                Id = 1,
                Message = message,
                SenderName = this.Name
            };
            await _mediator.Send(messageToSend);
        }

        public async Task ReceiveMessage(string senderName, string message)
        {
            Console.WriteLine($"User {Name} received message: {message} from sender {senderName}");
        }
    }
}
