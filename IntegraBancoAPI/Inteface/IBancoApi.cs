using IntegraBancoAPI.Dtos;
using IntegraBancoAPI.Models;

namespace IntegraBancoAPI.Inteface
{
    public interface IBancoApi
    {
        Task<ResponseService<List<BancoModel>>> BuscaTodosBancos();
        Task<ResponseService<EnderecoModel>> BuscarEnderecoPorCep(string cep);
        Task<ResponseService<BancoModel>> BuscaBanco(string codigoBanco);
    }
}
