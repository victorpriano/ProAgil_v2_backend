using System;
using Flunt.Notifications;
using Flunt.Validations;
using ProAgil.Shared.Commands;

namespace ProAgil.Domain.Commands.Palestrantes
{
    public class UpdatePalestranteCommand : Notifiable<Notification>, ICommand
    {
        public UpdatePalestranteCommand(Guid id, string nome, string miniCurriculo, string imagemUrl, string telefone, string email)
        {
            Id = id;
            Nome = nome;
            MiniCurriculo = miniCurriculo;
            ImagemUrl = imagemUrl;
            Telefone = telefone;
            Email = email;
        }

        public Guid Id { get; private set; }
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