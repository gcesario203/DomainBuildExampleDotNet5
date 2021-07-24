using System;
using Domain.Entities.ValueObjects;

namespace Domain.Entities.PetContext
{
    public abstract class BaseEntity
    {
        //GUID = Global Unique Identifier
        public Guid Id { get; private set; }

        public Name Name { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public BaseEntity(Name pName)
        {
            this.Id = Guid.NewGuid();
            this.Name = pName;
            this.CreatedAt = DateTime.UtcNow;
        }
    }
}