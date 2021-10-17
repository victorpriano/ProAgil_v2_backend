using System;
using System.Collections.Generic;
using ProAgil.Shared.Entities;

namespace ProAgil.Domain.Entities
{
    public class Evento : Entity 
    {
        public Evento()
        {
            
        }
        public Evento(string local, DateTime? dataEvento, string tema, int qtdPessoas, string imagemUrl, string telefone, string email)
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
        public DateTime? DataEvento { get; private set; }
        public string Tema { get; private set; }
        public int QtdPessoas { get; private set; }
        public string ImagemUrl { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public IReadOnlyCollection<Lote> Lotes { get; private set; }
        public IReadOnlyCollection<RedeSocial> RedeSociais { get; private set; }
        public IReadOnlyCollection<PalestranteEvento> PalestranteEventos { get; private set; }
    }
}