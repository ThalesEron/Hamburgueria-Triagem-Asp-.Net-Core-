using AutoMapper;
using Hamburgueria.DATA.Models;
using Hamburgueria.DATA.Models.DTO;

namespace Hamburgueria.DATA.Infrastructure.Mapping
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping() 
        {
            CreateMap<Ingrediente, IngredienteDTO>()
                .ForMember(dest => dest.Ind_ativo, m => m.MapFrom(origin => origin.Ativo))
                .ForMember(dest => dest.Dat_cadastro, m => m.MapFrom(origin => origin.DataCadastro))
                .ForMember(dest => dest.Id_ingrediente, m => m.MapFrom(origin => origin.Codigo))
                .ForMember(dest => dest.Nom_ingrediente, m => m.MapFrom(origin => origin.NomeIngrediente));

              
        } 
    }
}
