
namespace Strategy.Practice
{
    internal class Client
    {
        private readonly IEnumerable<INotificationService> _notifications;

        //this could be done with lazy to not instantiate all objects if not needed
        public Client(IEnumerable<INotificationService> notifications)
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
