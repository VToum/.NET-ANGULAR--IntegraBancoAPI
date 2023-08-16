using AutoMapper;
using IntegraBancoAPI.Dtos;
using IntegraBancoAPI.Inteface;

namespace IntegraBancoAPI.Services
{
    public class CorretoraService : ICorretoraService
    {
        public IBancoApi _bancoApi;
        public IMapper _mapper;
        public CorretoraService(IMapper mapper, IBancoApi bancoApi)
        {
            _mapper = mapper;
            _bancoApi = bancoApi;
        }

        public async Task<ResponseService<List<CorretoraDto>>> BuscaAllCorretoras()
        {
            var corretoras = await _bancoApi.BuscaTodasCorretoras();
            return _mapper.Map<ResponseService<List<CorretoraDto>>>(corretoras); 
        }

        public async Task<ResponseService<CorretoraDto>> BuscaCnpjCorretora(string cnpj)
        {
            var corretoras = await _bancoApi.BuscaCorretora(cnpj);
            return _mapper.Map<ResponseService<CorretoraDto>>(corretoras); 
        }
    }
}