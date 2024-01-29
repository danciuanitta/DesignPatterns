
using MediatR;

namespace Mediator.Practice.WithMediatR
{
    public class ChatMessage : IRequest
    {
        public int Id { get; set; }
        public string SenderName { get; set; }
        public string Message { get; set; }
    }
}
