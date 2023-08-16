using IntegraBancoAPI.Dtos;

namespace IntegraBancoAPI.Inteface
{
    public interface ICorretoraService
    {
        Task<ResponseService<List<CorretoraDto>>> BuscaAllCorretoras();

        Task<ResponseService<CorretoraDto>> BuscaCnpjCorretora(string cnpj);

    }
}
