using System;
using System.Collections.Generic;
using Domain.Validations.Interfaces;
using Domain.Notifications;

namespace Domain.Entities.VaccineContext
{
    public abstract class BaseEntity : IValidations
    {
        private List<Notification> _notifications;

        public IReadOnlyCollection<Notification> Notifications => _notifications;
        //GUID = Global Unique Identifier
        public Guid Id { get; private set; }

         public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public BaseEntity(string pDescription)
        {
            this.Id = Guid.NewGuid();
            this.Description = pDescription;
            this.CreatedAt = DateTime.UtcNow;
        }

        public virtual void SetDescription(string pDescription)
        {
            this.Description = pDescription;
        }

        public void SetNotifications(List<Notification> pNotificationList)
        {
            this._notifications = pNotificationList;
        }

        public abstract bool Validation();
    }
}