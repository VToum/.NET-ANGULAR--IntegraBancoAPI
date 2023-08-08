using IntegraBancoAPI.Dtos;
using IntegraBancoAPI.Models;

namespace IntegraBancoAPI.Inteface
{
    public interface IBancoServices
    {
        Task<ResponseService<List<BancoDto>>> BuscaTodos();
        Task<ResponseService<BancoDto>> BuscaBanco(string codigoBanco);
    }
}
