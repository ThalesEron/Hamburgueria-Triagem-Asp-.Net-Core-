using AutoMapper;
using Hamburgueria.DATA.DTO;
using Hamburgueria.DATA.Models;

namespace Hamburgueria.DATA.Infrastructure.Mapping
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping() 
        {
            CreateMap<Ingrediente, IngredienteDTO>()
                .ForMember(a => a.Id,
                    map => map.MapFrom(src => src.Codigo));

            CreateMap<IngredienteDTO, Ingrediente>()
               .ForMember(a => a.Codigo,
                   map => map.MapFrom(src => src.Id));


        } 
    }
}
