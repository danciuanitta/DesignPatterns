namespace Mediator.Practice
{
    //source https://www.youtube.com/watch?v=5tyRwBWGjQk
    internal class ChatMediator
    {
        private readonly IList<IUser> _users;

        public ChatMediator()
        {
            _users = new List<IUser>();
        }

        public void RegisterUser(IUser user)
        {
            _users.Add(user);
        }

        public void SendMessage(string senderName, string message)
        {
            var receivers = _users.Where(x => !x.Name.Equals(senderName));
            foreach(var user in receivers)
            {
                //if (user != sender)
                //{
                //    user.ReceiveMessage(message);
                //}

                user.ReceiveMessage(senderName,message);
            }
        }
    }
}
