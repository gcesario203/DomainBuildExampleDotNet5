using System;
using Domain.Validations;

namespace Domain.Entities.VaccineContext
{
    public class Vaccine : BaseEntity, IContract
    {
        public Guid CategoryId { get; private set; }
        public Guid PetId { get; private set; }

        public Vaccine(string pDescription, Guid pCategoryId, Guid pPetId) : base(pDescription)
        {
            this.CategoryId = pCategoryId;
            this.PetId = pPetId;
        }

        public override void SetDescription(string pDescription)
        {
            base.SetDescription(pDescription);
        }

        public override bool Validation()
        {
            var lContracts = new ContractValidations<Vaccine>()
                     .IsGuid(this.PetId, "Id invalido", "Vaccine.PetId")
                     .IsGuid(this.CategoryId, "Id invalido", "Vaccine.PetId")
                     .IsDescriptionOk(this.Description, 150, 80, "Descrição deve ficar entre 80 e 100 caracteres", "Vaccine.Description");

            return lContracts.IsValid();
        }
    }
}