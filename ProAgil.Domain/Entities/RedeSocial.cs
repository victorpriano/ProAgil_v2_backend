using System;
using ProAgil.Shared.Entities;

namespace ProAgil.Domain.Entities
{
    public class RedeSocial : Entity
    {
        public RedeSocial(string nome, string url)
        {
            Nome = nome;
            Url = url;
        }

        public string Nome { get; private set; }
        public string Url { get; private set; }
        public Guid? EventoId { get; private set; }
        public Evento Evento { get; }
        public Guid? PalestranteId { get; private set; }
        public Palestrante Palestrante { get; }
    }
}