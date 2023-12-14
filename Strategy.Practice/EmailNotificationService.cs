
namespace Strategy.Practice
{
    internal class EmailNotificationService : INotificationService
    {
        public string NotificationType => "Email";

        public void SendNotification()
        {
            Console.WriteLine("Notification sent by email.");
        }
    }
}
