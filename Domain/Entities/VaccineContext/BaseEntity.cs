using System;

namespace Domain.Entities.VaccineContext
{
    public abstract class BaseEntity
    {
        //GUID = Global Unique Identifier
        public Guid Id { get; private set; }

         public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public BaseEntity(string pDescription)
        {
            this.Id = Guid.NewGuid();
            this.Description = pDescription;
            this.CreatedAt = DateTime.UtcNow;
        }

        public virtual void SetDescription(string pDescription)
        {
            this.Description = pDescription;
        }
    }
}