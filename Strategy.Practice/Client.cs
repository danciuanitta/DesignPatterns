
namespace Strategy.Practice
{
    internal class Client
    {
        private readonly IList<INotificationService> _notifications;

        public Client(IList<INotificationService> notifications)
        {
            _notifications = notifications;
        }

        public void Operation()
        {
            //this should be caried by an factory not directly in client logic
            string notificationType = "Email";
            INotificationService? chosenStrategy = _notifications.FirstOrDefault(x => x.NotificationType.Equals(notificationType));
            if (chosenStrategy is null)
            {
                Console.WriteLine("No available strategy");
                return;
            }

            Context contextObject = new Context(chosenStrategy);

            contextObject.Operation();
        }
    }
}
