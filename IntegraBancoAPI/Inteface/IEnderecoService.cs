
using IntegraBancoAPI.Dtos;
using IntegraBancoAPI.Models;
using System.Text.Json.Serialization;

namespace IntegraBancoAPI.Inteface
{
    public interface IEnderecoService
    {
        Task<ResponseDto<EnderecoDto>> BuscarEndereco(string cep);
    }
}
