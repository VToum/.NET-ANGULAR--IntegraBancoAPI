using AutoMapper;
using IntegraBancoAPI.Dtos;
using IntegraBancoAPI.Inteface;
using IntegraBancoAPI.Models;

namespace IntegraBancoAPI.Services
{
    public class BancoService : IBancoServices
    {
        private readonly IMapper _mapper;
        private readonly IBancoApi _bancoApi;
        public BancoService(IBancoApi bancoApi, IMapper mapper)
        {
            _mapper = mapper;
            _bancoApi = bancoApi;
        }
        public async Task<ResponseService<List<BancoDto>>> BuscaTodos()
        {
            var bancos = await _bancoApi.BuscaTodosBancos();
            return _mapper.Map<ResponseService<List<BancoDto>>>(bancos);
        }

        public async Task<ResponseService<BancoDto>> BuscaBanco(string codigoBanco)
        {
            var banco = await _bancoApi.BuscaBanco(codigoBanco);
            return _mapper.Map<ResponseService<BancoDto>>(banco);
        }

    }
}
