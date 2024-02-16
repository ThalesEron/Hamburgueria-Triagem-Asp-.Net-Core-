using AutoMapper;
using Hamburgueria.DATA.DTO;
using Hamburgueria.DATA.Models;

namespace Hamburgueria.DATA.Infrastructure.Mapping
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping() 
        {
            CreateMap<Ingrediente, IngredienteDTO>();


        } 
    }
}
