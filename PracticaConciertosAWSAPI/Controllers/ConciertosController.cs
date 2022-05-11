using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PracticaConciertosAWSAPI.Models;
using PracticaConciertosAWSAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaConciertosAWSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConciertosController : ControllerBase
    {
        private RepositoryConciertos repo;

        public ConciertosController(RepositoryConciertos repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<List<Evento>> GetEventos()
        {
            return this.repo.GetEventos();
        }


        [HttpGet("[action]/{id}")]
        public ActionResult<List<Evento>> GetEventosCategoria(int id)
        {
            return this.repo.GetEventosByCategoria(id);
        }

        [HttpGet("[action]")]
        public ActionResult<List<CategoriaEvento>> GetCategorias()
        {
            return this.repo.GetCategorias();
        }

        [HttpGet("{id}")]
        public ActionResult<Evento> FindEvento(int id)
        {
            return this.repo.FindEvento(id);
        }

        [HttpPost]
        public ActionResult InsertarEvento(Evento ev)
        {
            this.repo.InsertarEvento(ev.IdEvento, ev.Nombre, ev.Artista, ev.IdCategoria);
            return Ok();
        }

        [HttpPut("{idevento}/{idcategoria}")]
        public ActionResult UpdateCategoriaEvento(int idevento, int idcategoria)
        {
            this.repo.UpdateCategoriaEvento(idevento, idcategoria);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteEvento(int id)
        {
            this.repo.DeleteEvento(id);
            return Ok();
        }
    }
}
