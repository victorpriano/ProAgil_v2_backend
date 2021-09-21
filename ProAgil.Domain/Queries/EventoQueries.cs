using System;
using System.Linq.Expressions;
using ProAgil.Domain.Entities;

namespace ProAgil.Domain.Queries
{
    public class EventoQueries
    {
        // public System.Guid Id { get; set; }
        // public string Local { get; set; }
        // public string Tema { get; set; }
        // public int QtdPessoas { get; set; }
        // public string ImagemUrl { get; set; }
        // public string Telefone { get; set; }
        // public string Email { get; set; }
        public static Expression<Func<Evento, bool>> GetEventosByTema(string tema)
        {
            return x => x.Tema == tema;
        }

    }
}