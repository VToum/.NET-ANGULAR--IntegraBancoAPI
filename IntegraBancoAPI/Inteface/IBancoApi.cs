using IntegraBancoAPI.Dtos;
using IntegraBancoAPI.Models;

namespace IntegraBancoAPI.Inteface
{
    public interface  IBancoApi
    {
        Task<ResponseService<List<BancoModel>>> BuscaTodosBancos();
        Task<ResponseService<BancoModel>> BuscaBanco(string codigoBanco);
        Task<ResponseService<List<CorretoraModel>>> BuscaTodasCorretoras();
        Task<ResponseService<CorretoraModel>> BuscaCorretora(string cnpj);
        Task<ResponseService<EnderecoModel>> BuscarEnderecoPorCep(string cep);
        
    }
}
