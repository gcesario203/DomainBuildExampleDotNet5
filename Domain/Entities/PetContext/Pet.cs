using Domain.Entities.ValueObjects;
using Domain.Validations;

namespace Domain.Entities.PetContext
{
    public class Pet : BaseEntity, IContract
    {
        public int Identifier { get; private set; }

        public Pet(Name pName,
                   int pIdentifier) : base(pName)
        {
            this.Identifier = pIdentifier;
        }

        public void SetIdentifier(int pIdentifier)
        {
            this.Identifier = pIdentifier;
        }

        public override bool Validation()
        {
            var lContracts = new ContractValidations<Pet>()
                                  .IsGuid(this.Id, "ID Unico inválido", "Pet.id")
                                  .FirstNameOk(this.Name, 20, 5, "O primeiro nome deve conter entre 5 e 20 caracteres", "Pet.FirstName")
                                  .LastNameOk(this.Name, 20, 5, "O ultimo nome deve estar conter entre 5 e 20 caracteres", "Pet.Lastname");

            return lContracts.IsValid();
        }
    }
}