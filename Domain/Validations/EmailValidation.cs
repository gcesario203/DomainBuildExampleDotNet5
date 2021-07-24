using System;
using System.Net.Mail;
using Domain.Entities.NotificationContext;

namespace Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> EmailIsOk(string pEmail, string pMessage, string pProperty)
        {
            try
            {
                MailAddress m = new MailAddress(pEmail);

                return this;
            }
            catch (FormatException)
            {
                AddNotification(new Notification(pMessage, pProperty));

                return this;
            }
        }
    }
}