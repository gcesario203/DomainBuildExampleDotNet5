using Domain.Validations;

namespace Domain.Entities.VaccineContext
{
    public class Category : BaseEntity, IContract
    {
       public Category(string pDescription) : base( pDescription )
       {
           
       }

        public override void SetDescription(string pDescription)
        {
            base.SetDescription(pDescription);
        }

        public override bool Validation()
        {
            var lContracts = new ContractValidations<Category>()
                                 .IsDescriptionOk(this.Description, 150, 80, "Descrição deve ficar entre 80 e 100 caracteres", "Category.Description");

            return lContracts.IsValid();
        }
    }
}