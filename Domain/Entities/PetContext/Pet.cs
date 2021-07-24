namespace Domain.Entities.PetContext
{
    public class Pet : BaseEntity
    {
        public int Identifier { get; private set; }

        public Pet(string pFirstName,
                   string pLastName,
                   int pIdentifier) : base( pFirstName, pLastName )
        {
            this.Identifier = pIdentifier;
        }

        public void SetIdentifier(int pIdentifier)
        {
            this.Identifier = pIdentifier;
        }
    }
}