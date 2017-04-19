using Fantasy_Surf.Application.WebApi.ViewModels;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fantasy_Surf.Application.WebApi.Controllers
{
    public class SurferController : ApiController
    {

        [HttpGet]
        public HttpResponseMessage Get()
        {
            if (!ModelState.IsValid)           
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Mensagem = "Modelo desconhecido!"});

            var surfers = new List<SurferViewModel>();
            surfers.Add(new SurferViewModel { Id = 1, Nome = "Renan Frutuozo", Apelido = "Frutuozo" });
            surfers.Add(new SurferViewModel { Id = 2, Nome = "Jorge Miranda", Apelido = "Miranda" });
            surfers.Add(new SurferViewModel { Id = 3, Nome = "Luciano Fernandes", Apelido = "Coroa Tomador de Cerveja" });
            surfers.Add(new SurferViewModel { Id = 4, Nome = "Luiz Carlos", Apelido = "Guru" });
            surfers.Add(new SurferViewModel { Id = 5, Nome = "José Castelo", Apelido = "Castelo" });
            surfers.Add(new SurferViewModel { Id = 6, Nome = "Mário Leitão", Apelido = "Mário" });
            surfers.Add(new SurferViewModel { Id = 7, Nome = "Pedro Gondim", Apelido = "Pedro" });
            surfers.Add(new SurferViewModel { Id = 8, Nome = "Daniel Viana", Apelido = "Zacarias" });
            surfers.Add(new SurferViewModel { Id = 9, Nome = "Gabriel Viana", Apelido = "Gabriel" });
            surfers.Add(new SurferViewModel { Id = 10, Nome = "Valderi Neto", Apelido = "Valderi" });
            surfers.Add(new SurferViewModel { Id = 11, Nome = "Tiago Diogenis", Apelido = "Tiago" });
            surfers.Add(new SurferViewModel { Id = 12, Nome = "Rodrigo Pipoca", Apelido = "Pipoca" });
            surfers.Add(new SurferViewModel { Id = 13, Nome = "Victor Zenchiro", Apelido = "Zen" });
            return Request.CreateResponse(HttpStatusCode.Accepted, surfers);            
        }
    }
}
