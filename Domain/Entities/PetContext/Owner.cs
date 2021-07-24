using Domain.Entities.ValueObjects;

namespace Domain.Entities.PetContext
{
    public class Owner : BaseEntity
    {
        public string Email { get; private set; }

        public Document Dpcument { get; private set; }

        public Owner(Name pName,
                       string pEmail,
                       Document pDocument) : base(pName)
        {
            this.Email = pEmail;
            this.Dpcument = pDocument;
        }

        public void SetEmail(string pEmail)
        {
            this.Email = pEmail;
        }
    }
}