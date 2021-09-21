using System;
using Flunt.Notifications;
using Flunt.Validations;
using ProAgil.Shared.Commands;

namespace ProAgil.Domain.Commands.Evento
{
    public class DeleteEventoCommand : Notifiable<Notification>, ICommand
    {
        public Guid Id { get; private set; }
        public string Tema { get; private set; }
        
        public DeleteEventoCommand(Guid id, string tema)
        {
            Id = id;
            Tema = tema;
        }

        public void Validate()
        {
            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsEmpty(Id, "Id inválido!")
                .IsNullOrEmpty(Tema, "tema não pode ser nulo ou vazio")
            );
        }
    }
}