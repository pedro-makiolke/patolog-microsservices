using System;
using Estoque.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Estoque.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class EstoqueController : ControllerBase
    {
        private readonly IEstoqueService _estoqueService;
        
        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            try
            {
                var estoques = _estoqueService.BuscarEstoqueProdutos();
                
                return Ok(estoques);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [Route("/{uuid:string}")]
        public IActionResult GetById(string uuid)
        {
            try
            {
                var estoque = _estoqueService.BuscarEstoquePorUuid(uuid);

                if (estoque == null)
                {
                    return NotFound();
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}