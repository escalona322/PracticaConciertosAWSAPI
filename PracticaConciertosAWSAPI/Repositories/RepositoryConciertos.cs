using PracticaConciertosAWSAPI.Data;
using PracticaConciertosAWSAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaConciertosAWSAPI.Repositories
{
    public class RepositoryConciertos
    {
        private ConciertosContext context;

        public RepositoryConciertos(ConciertosContext context)
        {
            this.context = context;
        }

        #region Metodos Categorias
        public List<CategoriaEvento> GetCategorias()
        {         
            return this.context.Categorias.ToList();
        }
        #endregion

        #region Metodos Eventos

        public List<Evento> GetEventos()
        {
            return this.context.Eventos.ToList();
        }

        public List<Evento> GetEventosByCategoria(int idcategoria)
        {
            List<Evento> eventos = this.context.Eventos.Where(x => x.IdCategoria == idcategoria).ToList();
            return eventos;
        }

        public int GetMaxIdEvento()
        {
            int maxid = this.context.Eventos.Max(x => x.IdEvento);
            return maxid + 1;
        }

        public void InsertarEvento(int idevento, string nombre, string artista, int idcategoria)
        {
            int maxid = this.GetMaxIdEvento();
            Evento ev = new Evento()
            {
                IdEvento = maxid,
                Nombre = nombre,
                Artista = artista,
                IdCategoria = idcategoria
            };

            this.context.Eventos.Add(ev);
            this.context.SaveChanges();
        }

        public Evento FindEvento(int idevento)
        {
            return this.context.Eventos.Where(x => x.IdEvento == idevento).SingleOrDefault();
        }
        public void UpdateCategoriaEvento(int idevento, int idcategoria)
        {
            Evento ev = this.FindEvento(idevento);
            ev.IdCategoria = idcategoria;
            this.context.SaveChanges();
        }

        public void DeleteEvento(int idevento)
        {
            Evento ev = this.FindEvento(idevento);

            this.context.Eventos.Remove(ev);
            this.context.SaveChanges();
        }
        #endregion
    }
}
