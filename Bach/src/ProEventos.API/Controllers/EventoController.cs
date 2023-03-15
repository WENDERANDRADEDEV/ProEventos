using System;
using ProEventos.API.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase


    {

        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){
                            EventoId = 1,
                            Local = "Macuco de Minas",
                            Tema = "Angular 11 e .NET 5",
                            Lote = "1º Lote",
                            QtdPessoas = 250,
                            DataEvento = DateTime.Now.AddDays(1).ToString("dd/MM/yyyy"),
                            ImagemURL = "Imagem.png.br"
                },
                  new Evento(){
                            EventoId = 2,
                            Local = "São Paulo",
                            Tema = "Angular 11 e suas Novidades",
                            Lote = "2º Lote",
                            QtdPessoas = 350,
                            DataEvento = DateTime.Now.AddDays(1).ToString("dd/MM/yyyy"),
                            ImagemURL = "Imagem22.png.br"
                }

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


        [HttpPost]
        public string Post()
        {
            return "Exeplo de Post";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exeplo de Put com idv={id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exeplo de Delete com id = {id}";
        }
    }
}
