using AutoMapper;
using IntegraBancoAPI.Dtos;
using IntegraBancoAPI.Models;

namespace IntegraBancoAPI.Mappings
{
    public class BancoMapping : Profile
    {
        //Metodo padrão do AutoMapper Banco
        public BancoMapping()
        {
            CreateMap(typeof(ResponseService<>), typeof(ResponseService<>));

            CreateMap<BancoModel, BancoDto>();
            CreateMap<BancoDto, BancoModel>();
        
        }

    }
}