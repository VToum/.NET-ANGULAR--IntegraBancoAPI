using IntegraBancoAPI.Dtos;
using IntegraBancoAPI.Models;

namespace IntegraBancoAPI.Inteface
{
    public interface IBancoServices
    {
        Task<ResponseService<List<BancoDto>>> BuscaAllBancos();
        Task<ResponseService<BancoDto>> BuscaCodigoBanco(string codigoBanco);
    }
}
