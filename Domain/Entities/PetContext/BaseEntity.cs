using System;
using System.Collections.Generic;
using Domain.Entities.ValueObjects;
using Domain.Notifications;
using Domain.Validations.Interfaces;

namespace Domain.Entities.PetContext
{
    public abstract class BaseEntity : IValidations
    {
        private List<Notification> _notifications;
        //GUID = Global Unique Identifier
        public Guid Id { get; private set; }

        public Name Name { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public IReadOnlyCollection<Notification> Notifications => _notifications;

        protected void SetNotifications(List<Notification> pNotificationList)
        {
            this._notifications = pNotificationList;
        }

        public BaseEntity(Name pName)
        {
            this.Id = Guid.NewGuid();
            this.Name = pName;
            this.CreatedAt = DateTime.UtcNow;
        }

        public abstract bool Validation();
    }
}