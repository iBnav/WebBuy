using Microsoft.AspNetCore.Mvc;
using System;
using WebBuy.Dominio.Entidades;

namespace WebBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    public class UserController : Controller
    {
        [HttpPost("VerificarUsuario")]
        public ActionResult VerificarUsuario([FromBody]Usuario user)
        {
            try
            {
                if (user.Email == "igor.benavente@unip.br" && user.Senha == "0802")
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
