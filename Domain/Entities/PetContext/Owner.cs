using System;
using System.Net.Mail;
using Domain.Entities.ValueObjects;
using Domain.Validations;

namespace Domain.Entities.PetContext
{
    public class Owner : BaseEntity, IContract
    {
        public string Email { get; private set; }

        public Document Document { get; private set; }

        public Owner(Name pName,
                       string pEmail,
                       Document pDocument) : base(pName)
        {
            this.Email = pEmail;
            this.Document = pDocument;
        }

        public void SetEmail(string pEmail)
        {
            this.Email = pEmail;
        }

        public override bool Validation()
        {
            var lContracts = new ContractValidations<Owner>()
                                  .IsGuid(this.Id, "ID Unico inválido", "Owner.Id")
                                  .FirstNameOk(this.Name, 20, 5, "O primeiro nome deve conter entre 5 e 20 caracteres", "Owner.FirstName")
                                  .LastNameOk(this.Name, 20, 5, "O ultimo nome deve estar conter entre 5 e 20 caracteres", "Owner.Lastname")
                                  .EmailIsOk(this.Email, "Email com formato incorreto", "Owner.Email")
                                  .IsDocumentOk(this.Document, "Documento inválido", "Owner.Document"); 

            return lContracts.IsValid();
        }
    }
}