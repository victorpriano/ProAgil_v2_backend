using System;
using Flunt.Notifications;

namespace ProAgil.Shared.Entities
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }

    }
}