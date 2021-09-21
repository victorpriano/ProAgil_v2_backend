using System;
using Flunt.Notifications;
using Flunt.Validations;
using ProAgil.Shared.Commands;

namespace ProAgil.Domain.Commands.Eventos
{
    public class AddEventoCommand : Notifiable<Notification>, ICommand
    {
        public AddEventoCommand(string local, DateTime dataEvento, string tema, int qtdPessoas, string imagemUrl, string telefone, string email)
        {
            Local = local;
            DataEvento = dataEvento;
            Tema = tema;
            QtdPessoas = qtdPessoas;
            ImagemUrl = imagemUrl;
            Telefone = telefone;
            Email = email;
        }

        public string Local { get; private set; }
        public DateTime DataEvento { get; private set; }
        public string Tema { get; private set; }
        public int QtdPessoas { get; private set; }
        public string ImagemUrl { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }

        public void Validate()
        {
            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNullOrEmpty(Local, "Local não pode ser nulo ou vazio")
                .IsNullOrEmpty(Tema, "Tema não pode ser nulo ou vazio")
            );
        }
    }
}