using System;

namespace Domain.Entities.PetContext
{
    public class Owner : BaseEntity
    {
        public string Email { get; private set; }
        public string DocumentNumber { get; private set; }
        public int DocumentType { get; set; }

        public Owner(string pFirstName,
                       string pLastName,
                       string pEmail,
                       string pDocumentNumber,
                       int pDocumentType) : base(pFirstName, pLastName)
        {
            this.Email = pEmail;
            this.DocumentNumber = pDocumentNumber;
            this.DocumentType = pDocumentType;
        }

        public void SetEmail(string pEmail)
        {
            this.Email = pEmail;
        }
    }
}