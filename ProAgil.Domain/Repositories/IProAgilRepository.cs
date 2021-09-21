using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProAgil.Domain.Entities;
using ProAgil.Domain.Queries;

namespace ProAgil.Domain.Repositories
{
    public interface IProAgilRepository
    {
         void Create(Evento evento);
         void Create(Lote lote);
         void Create(Palestrante palestrante);
         void Create(RedeSocial redeSocial);

         void Update(Evento evento);
         void Update(Lote lote);
         void Update(Palestrante palestrante);
         void Update(RedeSocial redeSocial);

         void Delete(Evento evento);
         void Delete(Lote lote);
         void Delete(Palestrante palestrante);
         void Delete(RedeSocial redeSocial);

         IEnumerable<Evento> GetAllEventoByTema(string tema);
         IEnumerable<Evento> GetAllEventos();
         Evento GetEventosById(Guid id, string tema);
         Evento GetEventoId(Guid id);
         Evento GetAllEventosById(Guid id, string tema);
         Lote GetAllLoteById(Guid id, string nome);
         Lote GetLoteById(Guid id);
         IEnumerable<Lote> GetAllLote();
         RedeSocial GetAllRedeSocialById(Guid id, string nome);
         RedeSocial GetRedeSocialById(Guid id);
         IEnumerable<RedeSocial> GetAllRedeSocial();
         Palestrante GetAllPalestranteById(Guid id, string nome);
         Palestrante GetPalestranteById(Guid id);
         IEnumerable<Palestrante> GetAllPalestrante();
         
    }
}