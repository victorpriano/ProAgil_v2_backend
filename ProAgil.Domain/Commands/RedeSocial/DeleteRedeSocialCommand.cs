using System;
using Flunt.Notifications;
using Flunt.Validations;
using ProAgil.Shared.Commands;

namespace ProAgil.Domain.Commands.RedeSocial
{
    public class DeleteRedeSocialCommand : Notifiable<Notification>, ICommand
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public bool Validate()
        {
           AddNotifications(new Contract<Notification>()
                .Requires()
                .IsEmpty(Id, "Id inválido!")
                .IsNotNullOrEmpty(Nome, "tema não pode ser nulo ou vazio")
            );

            return IsValid;
        }
    }
}