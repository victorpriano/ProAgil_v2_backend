using Flunt.Notifications;
using Flunt.Validations;
using ProAgil.Shared.Commands;

namespace ProAgil.Domain.Commands.Palestrantes
{
    public class AddPalestranteCommand : Notifiable<Notification>, ICommand
    {
        public AddPalestranteCommand(string nome, string miniCurriculo, string imagemUrl, string telefone, string email)
        {
            Nome = nome;
            MiniCurriculo = miniCurriculo;
            ImagemUrl = imagemUrl;
            Telefone = telefone;
            Email = email;
        }

        public string Nome { get; private set; }
        public string MiniCurriculo { get; private set; }
        public string ImagemUrl { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }

        public void Validate()
        {
            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNullOrEmpty(Nome, "Nome não pode ser nulo ou vazio")
                .IsEmail(Email, "Email inválido")
            );
        }
    }
}