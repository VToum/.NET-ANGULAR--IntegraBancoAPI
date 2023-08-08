
using IntegraBancoAPI.Dtos;
using IntegraBancoAPI.Models;
using System.Text.Json.Serialization;

namespace IntegraBancoAPI.Inteface
{
    public interface IEnderecoService
    {
        Task<ResponseService<EnderecoDto>> BuscarEndereco(string cep);
    }
}
