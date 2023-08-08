using System.Dynamic;
using System.Runtime.ConstrainedExecution;
using System.Text.Json;
using IntegraBancoAPI.Dtos;
using IntegraBancoAPI.Inteface;
using IntegraBancoAPI.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace IntegraBancoAPI.Rest
{
    public class BancoApiRest : IBancoApi
    {
        public async Task<ResponseService<List<BancoModel>>> BuscaTodosBancos()
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1");

            var response = new ResponseService<List<BancoModel>>();
            using (var client = new HttpClient())
            {
                var responseBancoApi = await client.SendAsync(request);
                var contentResp = await responseBancoApi.Content.ReadAsStringAsync();
                var objReponse = JsonSerializer.Deserialize<List<BancoModel>>(contentResp);

                if (responseBancoApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBancoApi.StatusCode;
                    response.DadosRetorno = objReponse;
                }
                else
                {
                    response.CodigoHttp = responseBancoApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }

            }
            return response;

        }

        public async Task<ResponseService<BancoModel>> BuscaBanco(string codigoBanco)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{codigoBanco}");

            var response = new ResponseService<BancoModel>();
            using (var client = new HttpClient())
            {
                var responseBancoApi = await client.SendAsync(request);
                var contentResp = await responseBancoApi.Content.ReadAsStringAsync();
                var objReponse = JsonSerializer.Deserialize<BancoModel>(contentResp);

                if (responseBancoApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBancoApi.StatusCode;
                    response.DadosRetorno = objReponse;
                }
                else
                {
                    response.CodigoHttp = responseBancoApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }

            }
            return response;
        }

        public async Task<ResponseService<EnderecoModel>> BuscarEnderecoPorCep(string cep)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");

            var response = new ResponseService<EnderecoModel>();
            var client = new HttpClient();
            var responseBancoApi = await client.SendAsync(request);
            var contentResp = await responseBancoApi.Content.ReadAsStringAsync();
            var objReponse = JsonSerializer.Deserialize<EnderecoModel>(contentResp);

            if (responseBancoApi.IsSuccessStatusCode)
            {
                response.CodigoHttp = responseBancoApi.StatusCode;
                response.DadosRetorno = objReponse;
            }
            else
            {
                response.CodigoHttp = responseBancoApi.StatusCode;
                response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
            }
            return response;

        }

    }
}
