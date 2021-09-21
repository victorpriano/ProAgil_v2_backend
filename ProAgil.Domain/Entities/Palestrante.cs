using System.Collections.Generic;
using ProAgil.Shared.Entities;

namespace ProAgil.Domain.Entities
{
    public class Palestrante : Entity
    {
        public Palestrante(string nome, string miniCurriculo, string imagemUrl, string telefone, string email)
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
        public IReadOnlyCollection<RedeSocial> RedeSociais { get; private set; }
        public IReadOnlyCollection<PalestranteEvento> PalestranteEventos { get; private set; }
    }
}