using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBuy.Dominio.Entidades;
using WebBuy.Dominio.Interfaces;

namespace WebBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_produtoRepository.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult Post([FromBody]Produto prod)
        {
            try
            {
                _produtoRepository.Adicionar(prod);
                return Created("api/produto", prod);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
