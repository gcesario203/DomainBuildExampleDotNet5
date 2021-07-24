using Domain.Notifications;

namespace Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> IsDescriptionOk(string pDescription, short pMaxLength, short pMinLength, string pMessage, string pProperty)
        {
            if (string.IsNullOrEmpty(pDescription) ||
              (pDescription.Length < pMinLength) ||
              (pDescription.Length > pMaxLength))
            {
                AddNotification(new Notification(pMessage, pProperty));
            }
            return this;
        }
    }
}