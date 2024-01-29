using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Practice.WithMediatR
{
    public class ChatMessageHandler : IRequestHandler<ChatMessage>
    {
        private readonly UserRegistrar userRegistrar;

        public ChatMessageHandler(UserRegistrar userRegistrar)
        {
            this.userRegistrar = userRegistrar;
        }

        public async Task Handle(ChatMessage request, CancellationToken cancellationToken)
        {
            Console.WriteLine("Handling message request");

            var receivers = userRegistrar.ChatUsers.Where(x => !x.Name.Equals(request.SenderName));
            foreach (var user in receivers)
            {
                await user.ReceiveMessage(request.SenderName, request.Message);
            }
        }
    }
}
