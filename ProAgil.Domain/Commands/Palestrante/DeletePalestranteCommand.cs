using System;
using Flunt.Notifications;
using Flunt.Validations;
using ProAgil.Shared.Commands;

namespace ProAgil.Domain.Commands.Palestrante
{
    public class DeletePalestranteCommand : Notifiable<Notification>, ICommand
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public void Validate()
        {
            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsEmpty(Id, "Id inválido!")
                .IsNullOrEmpty(Nome, "tema não pode ser nulo ou vazio")
            );
        }
    }
}