namespace Domain.Entities.VaccineContext
{
    public class Category : BaseEntity
    {
       public Category(string pDescription) : base( pDescription )
       {
           
       }

        public override void SetDescription(string pDescription)
        {
            base.SetDescription(pDescription);
        }
    }
}