using System.Net;
using IntegraBancoAPI.Dtos;
using IntegraBancoAPI.Inteface;
using IntegraBancoAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntegraBancoAPI.Controllers
{
    [ApiController]
    [Route("api/V1/[Controller]")]
    public class BancoController : ControllerBase
    {
        private readonly IBancoServices _bancoService;
        public BancoController(IBancoServices bancoService)
        {
            _bancoService = bancoService;
        }

        [HttpGet("busca/")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> BuscaTodos()
        {
            var response = await _bancoService.BuscaTodos();
            
            if(response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }

        [HttpGet("busca/{codigoBanco}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> BuscaBanco(string codigoBanco)
        {
            var response = await _bancoService.BuscaBanco(codigoBanco);

            if(response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}
