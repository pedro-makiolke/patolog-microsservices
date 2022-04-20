using System;
using Microsoft.AspNetCore.Mvc;
using Produto.Services.Interfaces;

namespace Produto.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            try
            {
                var produtos = _produtoService.GetAll();
                return Ok(produtos);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet]
        [Route("/{uuid}")]
        public IActionResult GetByUuid(string uuid)
        {
            try
            {
                var produto = _produtoService.GetByUuid(uuid);
                if (produto == null)
                {
                    return NotFound();
                }

                return Ok(produto);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}