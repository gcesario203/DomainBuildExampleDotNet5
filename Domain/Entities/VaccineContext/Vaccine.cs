using System;

namespace Domain.Entities.VaccineContext
{
    public class Vaccine : BaseEntity
    {
        public Guid CategoryId { get;  private set; }
        public Guid PetId {get; private set; }

        public Vaccine(string pDescription, Guid pCategoryId, Guid pPetId) : base(pDescription)
        {
            this.CategoryId = pCategoryId;
            this.PetId = pPetId;
        }

        public override void SetDescription(string pDescription)
        {
            base.SetDescription(pDescription);
        }
    }
}