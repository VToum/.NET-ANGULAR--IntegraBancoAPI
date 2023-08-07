using IntegraBancoAPI.Dtos;
using IntegraBancoAPI.Models;

namespace IntegraBancoAPI.Inteface
{
    public interface IBancoApi
    {
        Task<ResponseDto<BancoModel>> BuscarTodosBancos();
        Task<ResponseDto<EnderecoModel>> BuscarEnderecoPorCep(string cep);
        Task<ResponseDto<BancoModel>> BuscarBancoId(string codigoBanco);
    }
}
