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

        public EstoqueController(IEstoqueService estoqueService)
        {
            _estoqueService = estoqueService;
        }

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
        [Route("/{uuid}")]
        public IActionResult GetById(string uuid)
        {
            try
            {
                if (uuid == null)
                {
                    return BadRequest();
                };

                var estoque = _estoqueService.BuscarEstoquePorUuid(uuid);

                if (estoque == null)
                {
                    return NotFound();
                }

                return Ok(estoque);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}