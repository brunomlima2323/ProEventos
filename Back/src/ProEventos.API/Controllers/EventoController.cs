using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){
                    EventoId = 1,
                    Tema = "Angular 11e .NET 5",
                    Local = "Belo Horizonte",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                    Lote = "1º Lote",
                    ImagemURL = ".jpg"
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Angular 11e .NET 5",
                    Local = "Fortaleza",
                    QtdPessoas = 300,
                    DataEvento = DateTime.Now.AddDays(15).ToString(),
                    Lote = "2º Lote",
                    ImagemURL = "2.jpg"
                },
            };
        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }
    }
}
