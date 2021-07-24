using Domain.Entities.ValueObjects;
using Domain.Notifications;

namespace Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> FirstNameOk(Name pName, short pMaxLength, short pMinLength, string pMessage, string pPropertyName)
        {
            if (string.IsNullOrEmpty(pName.FirstName) ||
              (pName.FirstName.Length < pMinLength) ||
              (pName.FirstName.Length > pMaxLength))
            {
                AddNotification(new Notification(pMessage, pPropertyName));
            }

            return this;
        }

        public ContractValidations<T> LastNameOk(Name pName, short pMaxLength, short pMinLength, string pMessage, string pPropertyName)
        {
            if (string.IsNullOrEmpty(pName.LastName) ||
              (pName.LastName.Length < pMinLength) ||
              (pName.LastName.Length > pMaxLength))
            {
                AddNotification(new Notification(pMessage, pPropertyName));
            }

            return this;
        }
    }
}