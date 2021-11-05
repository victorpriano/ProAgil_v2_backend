using System;
using System.Collections.Generic;
using ProAgil.Domain.Entities;
using ProAgil.Domain.Handlers;
using ProAgil.Domain.Repositories;

namespace ProAgil.Tests.Handlers
{
    public class MockProAgilRepository : IProAgilRepository
    {
        public void Create(Evento evento)
        {
            
        }

        public void Create(Lote lote)
        {
            
        }

        public void Create(Palestrante palestrante)
        {
            
        }

        public void Create(RedeSocial redeSocial)
        {
            
        }

        public void Delete(Evento evento)
        {
            
        }

        public void Delete(Lote lote)
        {
            throw new NotImplementedException();
        }

        public void Delete(Palestrante palestrante)
        {
            throw new NotImplementedException();
        }

        public void Delete(RedeSocial redeSocial)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Evento> GetAllEventoByTema(string tema)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Evento> GetAllEventos()
        {
            throw new NotImplementedException();
        }

        public Evento GetAllEventosById(Guid id, string tema)
        {
            return new Evento("natal", DateTime.Now, "c#", 10, "img.jpg", "999999999", "vic@vict.com.br");
        }

        public IEnumerable<Lote> GetAllLote()
        {
            throw new NotImplementedException();
        }

        public Lote GetAllLoteById(Guid id, string nome)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Palestrante> GetAllPalestrante()
        {
            throw new NotImplementedException();
        }

        public Palestrante GetAllPalestranteById(Guid id, string nome)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RedeSocial> GetAllRedeSocial()
        {
            throw new NotImplementedException();
        }

        public RedeSocial GetAllRedeSocialById(Guid id, string nome)
        {
            throw new NotImplementedException();
        }

        public Evento GetEventoId(Guid id)
        {
            var evento = new Evento();
            Delete(evento);

            return evento;
        }

        public Evento GetEventosById(Guid id, string tema)
        {
            throw new NotImplementedException();
        }

        public Lote GetLoteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Palestrante GetPalestranteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public RedeSocial GetRedeSocialById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Evento evento)
        {
            
        }

        public void Update(Lote lote)
        {
            
        }

        public void Update(Palestrante palestrante)
        {
            
        }

        public void Update(RedeSocial redeSocial)
        {
            
        }
    }
}