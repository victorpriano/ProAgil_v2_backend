using System;

namespace ProAgil.Domain.Entities
{
    public class PalestranteEvento
    {
        public Guid PalestranteId { get; private set; }
        public Palestrante Palestrante { get; private set; }
        public Guid EventoId { get; private set; }
        public Evento Evento { get; private set; }
    }
}