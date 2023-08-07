using AutoMapper;
using IntegraBancoAPI.Dtos;
using IntegraBancoAPI.Models;

namespace IntegraBancoAPI.Mappings
{
    public class EnderecoMapping : Profile
    {
        //metodo padrão do AutoMapper
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseDto<>), typeof(ResponseDto<>));
            CreateMap<EnderecoDto, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoDto>();
        }
    }
}
