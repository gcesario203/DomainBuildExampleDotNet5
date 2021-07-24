using System;

namespace Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> IsGuid(object pGuid, string pMessage, string pProperty)
        {
            if(pGuid! is Guid)
            {
                AddNotification(new Domain.Notifications.Notification(pMessage, pProperty));
            }

            return this;
        }
    }
}