using System.Net;
using AutoMapper;
using IntegraBancoAPI.Dtos;
using IntegraBancoAPI.Inteface;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace IntegraBancoAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CorretoraControlller : ControllerBase
    {
        public ICorretoraService _corretoraApi;
    
        public CorretoraControlller(ICorretoraService corretoraApi)
        {
            _corretoraApi = corretoraApi;
        }

        [HttpGet("busca/")]
        public async Task<ActionResult> GetAllCorretora()
        {
            var corretoras =  await _corretoraApi.BuscaAllCorretoras();
            
            if(corretoras.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(corretoras);
            }
            else
            {
                return StatusCode((int)corretoras.CodigoHttp, corretoras.ErroRetorno);
            }
        }

        [HttpGet("busca/{cnpj}")]
        public async Task<ActionResult> BuscaCorretatoraCnpj(string cnpj)
        {
            var corretoraCvm = await _corretoraApi.BuscaCnpjCorretora(cnpj);

            if(corretoraCvm.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(corretoraCvm);
            }
            else
            {
                return StatusCode((int)corretoraCvm.CodigoHttp, corretoraCvm.ErroRetorno);
            }
        }
    }
}