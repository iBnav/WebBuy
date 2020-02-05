using Microsoft.AspNetCore.Mvc;
using System;
using WebBuy.Dominio.Entidades;
using WebBuy.Dominio.Interfaces;

namespace WebBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    public class UserController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UserController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost("VerificarUsuario")]
        public ActionResult VerificarUsuario([FromBody]Usuario user)
        {
            try
            {
                var userReturn = _usuarioRepository.Obter(user);
                if (userReturn != null)
                    return Ok(user);
                else
                    return BadRequest("Usuário ou senha inválido");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
