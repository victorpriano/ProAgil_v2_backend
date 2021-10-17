using System;
using Flunt.Notifications;
using Flunt.Validations;
using ProAgil.Shared.Commands;

namespace ProAgil.Domain.Commands.Eventos
{
    public class UpdateEventoCommand : Notifiable<Notification>, ICommand
    {
        public UpdateEventoCommand(Guid id, string local, DateTime dataEvento, string tema, int qtdPessoas, string imagemUrl, string telefone, string email)
        {
            Id = id;
            Local = local;
            DataEvento = dataEvento;
            Tema = tema;
            QtdPessoas = qtdPessoas;
            ImagemUrl = imagemUrl;
            Telefone = telefone;
            Email = email;
        }

        public Guid Id { get; private set; }
        public string Local { get; private set; }
        public DateTime DataEvento { get; private set; }
        public string Tema { get; private set; }
        public int QtdPessoas { get; private set; }
        public string ImagemUrl { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        
        public bool Validate()
        {
            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNotEmpty(Id, "Id inválido!")
                .IsNotNullOrEmpty(Local, "Local não pode ser nulo ou vazio")
                .IsNotNullOrEmpty(Tema, "Tema não pode ser nulo ou vazio")
                .IsEmail(Email, "E-mail inválido")
            );

            return IsValid;
        }
    }
}