namespace Mediator.Practice
{
    public class MediatorClient
    {
        public void ChatFunctionality()
        {
            ChatMediator chatMediator = new ChatMediator();
            ChatUser user1 = new ChatUser(chatMediator, "user1");
            ChatUser user2 = new ChatUser(chatMediator, "user2");
            ChatUser user3 = new ChatUser(chatMediator, "user3");

            chatMediator.RegisterUser(user1);
            chatMediator.RegisterUser(user2);
            chatMediator.RegisterUser(user3);

            user1.SendMessage("Hello, everyone");
        }
    }
}
