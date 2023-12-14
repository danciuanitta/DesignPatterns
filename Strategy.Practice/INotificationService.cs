
namespace Strategy.Practice
{
    internal interface INotificationService
    {
        public string NotificationType { get; }
        void SendNotification();
    }
}
