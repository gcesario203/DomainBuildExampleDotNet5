using Domain.Entities.ValueObjects;

namespace Domain.Entities.PetContext
{
    public class Pet : BaseEntity
    {
        public int Identifier { get; private set; }

        public Pet(Name pName,
                   int pIdentifier) : base( pName )
        {
            this.Identifier = pIdentifier;
        }

        public void SetIdentifier(int pIdentifier)
        {
            this.Identifier = pIdentifier;
        }
    }
}