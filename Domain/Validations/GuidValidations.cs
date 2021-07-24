using System;
using Domain.Entities.NotificationContext;

namespace Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> IsGuid(object pGuid, string pMessage, string pProperty)
        {
            if(pGuid! is Guid)
            {
                AddNotification(new Notification(pMessage, pProperty));
            }

            return this;
        }
    }
}