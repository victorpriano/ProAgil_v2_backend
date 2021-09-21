using System;
using System.Linq.Expressions;
using ProAgil.Domain.Entities;

namespace ProAgil.Domain.Queries
{
    public class PalestranteQueries
    {
        // public System.Guid Id { get; set; }
        // public string Nome { get; set; }
        // public string MiniCurriculo { get; set; }
        // public string Telefone { get; set; }
        // public string Email { get; set; }
        public static Expression<Func<Palestrante, bool>> GetPalestranteByNome(string nome)
        {
            return x => x.Nome == nome;
        }
    }
}