namespace Domain.Entities.NotificationContext
{
    public class Notification
    {
        public string Message { get; private set; }
        public string PropertyName { get; private set; }

        public Notification(string message, string propertyName)
        {
            Message = message;
            PropertyName = propertyName;
        }
    }
}