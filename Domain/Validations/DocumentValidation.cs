using Domain.Entities.ValueObjects;

namespace Domain.Validations
{
    public partial class ContractValidations<T>
    {
        public ContractValidations<T> IsDocumentOk(Document pDocument,
                                                   string pMessage,
                                                   string pProperty)
        {
            if(pDocument.DocumentType == Enums.EDocumentTypes.CPF)
            {
                if(!IsCpfOk(pDocument.DocumentNumber))
                {
                    AddNotification(new Domain.Notifications.Notification(pMessage, pProperty));
                }
            }

            if(pDocument.DocumentType == Enums.EDocumentTypes.CNPJ)
            {
                if(!IsCnpjOk(pDocument.DocumentNumber))
                {
                    AddNotification(new Domain.Notifications.Notification(pMessage,pProperty));
                }
            }

            return this;
        }

        private bool IsCnpjOk(string pCnpj)
        {
            int[] lFirstMultiplier = new int[12] { 5,4,3,2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] lSecondMultiplier = new int[13] { 6, 5,4,3,2, 9, 8, 7, 6, 5, 4, 3, 2 };
            string lTempCnpj;
            string lDigit;
            int lSum;
            int lRest;

            pCnpj = pCnpj.Trim();
            pCnpj = pCnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (pCnpj.Length != 14)
                return false;

            lTempCnpj = pCnpj.Substring(0, 9);
            lSum = 0;

            for (int i = 0; i < 12; i++)
            {
                lSum += int.Parse(lTempCnpj[i].ToString()) * lFirstMultiplier[i];
            }
            lRest = lSum % 11;

            if (lRest < 2)
            {
                lRest = 0;
            }
            else
            {
                lRest = 11 - lRest;
            }

            lDigit = lRest.ToString();

            lTempCnpj = lTempCnpj = lDigit;
            lSum = 0;

            for (int i = 0; i < 13; i++)
            {
                lSum += int.Parse(lTempCnpj[i].ToString()) * lSecondMultiplier[i];
            }

            lRest = lSum % 11;

            if (lRest < 2)
            {
                lRest = 0;
            }
            else
            {
                lRest = 11 - lRest;
            }

            lDigit = lDigit + lRest.ToString();

            return pCnpj.EndsWith(lDigit);
        }

        private bool IsCpfOk(string pCpf)
        {
            int[] lFirstMultiplier = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] lSecondMultiplier = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string lTempCpf;
            string lDigit;
            int lSum;
            int lRest;

            pCpf = pCpf.Trim();
            pCpf = pCpf.Replace(".", "").Replace("-", "");

            if (pCpf.Length != 11)
                return false;

            lTempCpf = pCpf.Substring(0, 9);
            lSum = 0;

            for (int i = 0; i < 9; i++)
            {
                lSum += int.Parse(lTempCpf[i].ToString()) * lFirstMultiplier[i];
            }
            lRest = lSum % 11;

            if (lRest < 2)
            {
                lRest = 0;
            }
            else
            {
                lRest = 11 - lRest;
            }

            lDigit = lRest.ToString();

            lTempCpf = lTempCpf = lDigit;
            lSum = 0;

            for (int i = 0; i < 10; i++)
            {
                lSum += int.Parse(lTempCpf[i].ToString()) * lSecondMultiplier[i];
            }

            lRest = lSum % 11;

            if (lRest < 2)
            {
                lRest = 0;
            }
            else
            {
                lRest = 11 - lRest;
            }

            lDigit = lDigit + lRest.ToString();

            return pCpf.EndsWith(lDigit);
        }
    }
}