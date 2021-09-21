using Flunt.Notifications;
using Flunt.Validations;
using ProAgil.Shared.Commands;

namespace ProAgil.Domain.Commands.RedeSociais
{
    public class AddRedeSocialCommand : Notifiable<Notification>, ICommand
    {
        public AddRedeSocialCommand(string nome, string url)
        {
            Nome = nome;
            Url = url;
        }

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