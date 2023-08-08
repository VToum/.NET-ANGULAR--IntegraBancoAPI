using AutoMapper;
using IntegraBancoAPI.Dtos;
using IntegraBancoAPI.Models;

namespace IntegraBancoAPI.Mappings
{
    public class EnderecoMapping : Profile
    {
        //Metodo padrão do AutoMapper Endereco
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseService<>), typeof(ResponseService<>));

            CreateMap<EnderecoDto, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoDto>();

        }
    }
}
