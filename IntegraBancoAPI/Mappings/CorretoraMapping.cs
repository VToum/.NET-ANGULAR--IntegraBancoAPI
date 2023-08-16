using AutoMapper;
using IntegraBancoAPI.Dtos;
using IntegraBancoAPI.Models;

namespace IntegraBancoAPI.Mappings
{
    public class CorretoraMapping : Profile
    {
        public CorretoraMapping()
        {
            CreateMap(typeof(ResponseService<>), typeof(ResponseService<>));

            CreateMap<CorretoraDto, CorretoraModel>();
            CreateMap<CorretoraModel, CorretoraDto>();
        }
    }
}