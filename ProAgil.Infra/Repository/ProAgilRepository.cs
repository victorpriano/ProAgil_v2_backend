using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ProAgil.Domain.Entities;
using ProAgil.Domain.Queries;
using ProAgil.Domain.Repositories;
using ProAgil.Infra.Context;

namespace ProAgil.Infra.Repository
{
    public class ProAgilRepository : IProAgilRepository
    {
        private readonly ProAgilContext _context;
        
        public ProAgilRepository(ProAgilContext context)
        {
            _context = context;
        }

        public void Create(Evento evento)
        {
            _context.Eventos.Add(evento);
            _context.SaveChanges();
        }

        public void Create(Lote lote)
        {
            _context.Lotes.Add(lote);
            _context.SaveChanges();
        }

        public void Create(Palestrante palestrante)
        {
            _context.Palestrantes.Add(palestrante);
            _context.SaveChanges();
        }

        public void Create(RedeSocial redeSocial)
        {
            _context.RedeSociais.Add(redeSocial);
            _context.SaveChanges();
        }

        public void Delete(Evento evento)
        {
            _context.Eventos.Remove(evento);
            _context.SaveChanges();
        }

        public void Delete(Lote lote)
        {
            _context.Lotes.Remove(lote);
            _context.SaveChanges();
        }

        public void Delete(Palestrante palestrante)
        {
            _context.Palestrantes.Remove(palestrante);
            _context.SaveChanges();
        }

        public void Delete(RedeSocial redeSocial)
        {
            _context.RedeSociais.Remove(redeSocial);
            _context.SaveChanges();
        }

        public IEnumerable<Evento> GetAllEventoByTema(string tema)
        {
            return _context.Eventos.AsNoTracking().Where(EventoQueries.GetEventosByTema(tema)).OrderBy(x => x.Id);
        }

        public IEnumerable<Evento> GetAllEventos()
        {
            return _context.Eventos.AsNoTracking().ToList();
        }

        public Evento GetAllEventosById(Guid id, string tema)
        {
            return _context.Eventos.ToList().FirstOrDefault(x => x.Id == id && x.Tema == tema);
        }

        public IEnumerable<Lote> GetAllLote()
        {
            return _context.Lotes.AsNoTracking().ToList();
        }

        public Lote GetAllLoteById(Guid id, string nome)
        {
            return _context.Lotes.ToList().FirstOrDefault(x => x.Id == id && x.Nome == nome);
        }

        public IEnumerable<Palestrante> GetAllPalestrante()
        {
            return _context.Palestrantes.AsNoTracking().ToList();
        }

        public Palestrante GetAllPalestranteById(Guid id, string nome)
        {
            return _context.Palestrantes.FirstOrDefault(x => x.Id == id && x.Nome == nome);
        }

        public IEnumerable<RedeSocial> GetAllRedeSocial()
        {
            return _context.RedeSociais.AsNoTracking().ToList();
        }

        public RedeSocial GetAllRedeSocialById(Guid id, string nome)
        {
            return _context.RedeSociais.ToList().FirstOrDefault(x => x.Id == id && x.Nome == nome);
        }

        public Evento GetEventoId(Guid id)
        {
            return _context.Eventos.FirstOrDefault(x => x.Id == id);
        }

        public Evento GetEventosById(Guid id, string tema)
        {
            return _context.Eventos.FirstOrDefault(x => x.Id == id && x.Tema == tema);
        }

        public Lote GetLoteById(Guid id)
        {
            return _context.Lotes.FirstOrDefault(x => x.Id == id);
        }

        public Palestrante GetPalestranteById(Guid id)
        {
            return _context.Palestrantes.FirstOrDefault(x => x.Id == id);
        }

        public RedeSocial GetRedeSocialById(Guid id)
        {
            return _context.RedeSociais.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Evento evento)
        {
            _context.Entry(evento).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Update(Lote lote)
        {
            _context.Entry(lote).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Update(Palestrante palestrante)
        {
            _context.Entry(palestrante).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Update(RedeSocial redeSocial)
        {
            _context.Entry(redeSocial).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}