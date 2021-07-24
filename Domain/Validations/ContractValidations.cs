using System.Collections.Generic;
using Domain.Notifications;

namespace Domain.Validations
{
    public partial class ContractValidations<T> where T: IContract
    {
        private List<Notification> _notifications;

        public IReadOnlyCollection<Notification> Notifications => _notifications;

        public ContractValidations()
        {
            this._notifications = new List<Notification>();
        }

        public void AddNotification(Notification pNotification)
        {
            this._notifications.Add(pNotification);
        }

        public bool IsValid()
        {
            return this._notifications.Count == 0 ? true : false;
        }
    }
}