using System;
using Flunt.Notifications;
using Flunt.Validations;
using ProAgil.Shared.Commands;

namespace ProAgil.Domain.Commands.Evento
{
    public class DeleteEventoCommand : Notifiable<Notification>, ICommand
    {
        public Guid Id { get; private set; }
        
        public DeleteEventoCommand(Guid id)
        {
            Id = id;
        }

        public bool Validate()
        {
            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotEmpty(Id, "Id inválido!")
            );

            return IsValid;
        }
    }
}