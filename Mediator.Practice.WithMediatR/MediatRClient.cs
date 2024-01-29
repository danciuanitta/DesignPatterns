using MediatR;

namespace Mediator.Practice.WithMediatR
{
    public class MediatRClient
    {
        private readonly UserRegistrar registrar;
        private readonly IMediator mediator;

        public MediatRClient(UserRegistrar registrar, IMediator mediator)
        {
            this.registrar = registrar;
            this.mediator = mediator;
        }

        public void ChatFunctionality()
        {
            IUser user1 = new ChatUser(mediator, "user1");
            IUser user2 = new ChatUser(mediator, "user2");
            IUser user3 = new ChatUser(mediator, "user3");

            registrar.RegisterUser(user1);
            registrar.RegisterUser(user2);
            registrar.RegisterUser(user3);

            user1.SendMessage("Hello, everyone");
        }
    }
}
