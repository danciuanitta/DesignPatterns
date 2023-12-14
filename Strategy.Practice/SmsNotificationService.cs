
namespace Strategy.Practice
{
    internal class SmsNotificationService : INotificationService
    {
        public string NotificationType => "SMS";

        public void SendNotification()
        {
            Console.WriteLine("Notification sent by sms");
        }
    }
}
