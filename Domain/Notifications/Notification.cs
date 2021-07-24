using Domain.Notifications.Interfaces;

namespace Domain.Notifications
{
    public class Notification : INotification
    {
        public string Message { get; private set; }
        public string PropertyName { get; private set; }

        public Notification(string message, string propertyName)
        {
            Message = message;
            PropertyName = propertyName;
        }

        public void AddNotification()
        {
            throw new System.NotImplementedException();
        }
    }
}