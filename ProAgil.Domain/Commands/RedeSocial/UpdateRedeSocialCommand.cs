using System;
using Flunt.Notifications;
using Flunt.Validations;
using ProAgil.Shared.Commands;

namespace ProAgil.Domain.Commands.RedeSociais
{
    public class UpdateRedeSocialCommand : Notifiable<Notification>, ICommand
    {
        public UpdateRedeSocialCommand(Guid id, string nome, string url)
        {
            Id = id;
            Nome = nome;
            Url = url;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Url { get; private set; }

        public void Validate()
        {
            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsUrl(Url, "O campo não é url")
            );
        }
    }
}