using AutoMapper;
using IntegraBancoAPI.Dtos;
using IntegraBancoAPI.Inteface;

namespace IntegraBancoAPI.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IBancoApi _bancoApi;

        public EnderecoService(IMapper mapper, IBancoApi bancoapi)
        {
            _bancoApi = bancoapi;
            _mapper = mapper;
        }
        public async Task<ResponseService<EnderecoDto>> BuscarEndereco(string cep)
        {
            var endereco = await _bancoApi.BuscarEnderecoPorCep(cep);
            return _mapper.Map<ResponseService<EnderecoDto>>(endereco);
        }
    }
}
