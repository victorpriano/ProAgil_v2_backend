using System;
using ProAgil.Shared.Entities;

namespace ProAgil.Domain.Entities
{
    public class Lote : Entity
    {
        public Lote(string nome, decimal preco, DateTime? dataInicio, DateTime? dataFim, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            DataInicio = dataInicio;
            DataFim = dataFim;
            Quantidade = quantidade;
        }

        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public DateTime? DataInicio { get; private set; }
        public DateTime? DataFim { get; private set; }
        public int Quantidade { get; private set; }
        public Guid EventoId { get; private set; }
        public Evento Evento { get; }
    }
}