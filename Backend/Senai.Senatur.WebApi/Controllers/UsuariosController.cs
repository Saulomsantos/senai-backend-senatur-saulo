using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Senai.Senatur.WebApi.Interfaces;
using Senai.Senatur.WebApi.Repositories;

namespace Senai.Senatur.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarioRepository UsuarioRepository { get; set; }

        public UsuariosController()
        {
            UsuarioRepository = new UsuarioRepository();
        }

        [Authorize(Roles = "ADMINISTRADOR")]
        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(UsuarioRepository.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}