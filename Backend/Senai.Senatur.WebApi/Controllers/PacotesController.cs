using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Domains;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;

namespace Senai.Senatur.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PacotesController : ControllerBase
    {
        private IPacoteRepository PacoteRepository { get; set; }

        public PacotesController()
        {
            PacoteRepository = new PacoteRepository();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(PacoteRepository.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "ADMINISTRADOR")]
        [HttpPost]
        public IActionResult Post(Pacotes pacote)
        {
            try
            {
                PacoteRepository.Cadastrar(pacote);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [Authorize(Roles = "ADMINISTRADOR")]
        [HttpPut]
        public IActionResult Put(Pacotes pacote)
        {
            try
            {
                PacoteRepository.Alterar(pacote);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult BuscarPacotePorId(int id)
        {
            try
            {
                Pacotes pacoteBuscado = PacoteRepository.BuscarPacotePorId(id);

                if (pacoteBuscado == null)
                {
                    return NotFound();
                }

                return Ok(pacoteBuscado);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}