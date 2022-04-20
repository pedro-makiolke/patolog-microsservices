using System;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
using Precificacao.Services.Interfaces;

namespace Precificacao.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
    public class PrecoController : ControllerBase
    {
        private readonly IPrecoService _precoService;

        public PrecoController(IPrecoService precoService)
        {
            _precoService = precoService;
        }

        [Route("")]
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var precos = _precoService.GetAll();
                return Ok(precos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [Route("/{uuid:string}")]
        [HttpGet]
        public IActionResult GetByUuid(string uuid)
        {
            try
            {
                var preco = _precoService.GetByUuid(uuid);
                if (preco == null)
                {
                    return NotFound();
                }

                return Ok(preco);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [Route("/promocoes")]
        [HttpGet]
        public IActionResult GetPromocoesAtivas()
        {
            try
            {
                var promocoes = _precoService.GetPromos();

                if (promocoes == null)
                {
                    return NotFound();
                }

                return Ok(promocoes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}