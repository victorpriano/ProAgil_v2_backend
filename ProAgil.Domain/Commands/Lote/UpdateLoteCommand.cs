using System;
using Flunt.Notifications;
using Flunt.Validations;
using ProAgil.Shared.Commands;

namespace ProAgil.Domain.Commands.Lotes
{
    public class UpdateLoteCommand : Notifiable<Notification>, ICommand
    {
       public UpdateLoteCommand(Guid id, string nome, decimal preco, DateTime dataInicio, DateTime dataFim, int quantidade)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Quantidade = quantidade;
        }
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public DateTime? DataInicio { get; private set; }
        public DateTime? DataFim { get; private set; }
        public int Quantidade { get; private set; }

        public void Validate()
        {
            AddNotifications(new Contract<Notification>()
                .Requires()
                .IsNullOrEmpty(Nome, "Nome não pode ser nulo ou vazio")
            );
        }
    }
}