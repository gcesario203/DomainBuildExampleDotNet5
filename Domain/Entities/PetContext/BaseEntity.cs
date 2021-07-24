using System;

namespace Domain.Entities.PetContext
{
    public abstract class BaseEntity
    {
        //GUID = Global Unique Identifier
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public BaseEntity(string pFirstName, string pLastName)
        {
            this.Id = Guid.NewGuid();
            this.FirstName = pFirstName;
            this.LastName = pLastName;
            this.CreatedAt = DateTime.UtcNow();
        }
    }
}