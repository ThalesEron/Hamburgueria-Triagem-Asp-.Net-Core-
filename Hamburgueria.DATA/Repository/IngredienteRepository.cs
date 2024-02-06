using Hamburgueria.DATA.Infrastructure;
using Hamburgueria.DATA.Interfaces;
using Hamburgueria.DATA.Models;

namespace Hamburgueria.DATA.Repository
{
    public class IngredienteRepository : IIngredienteRepository
    {
        private readonly ConnectionContext _context = new();

        public string CadastrarIngrediente(Ingrediente ingrediente)
        {

            IngredienteDto newIngrediente = new()
            {
                ind_ativo = ingrediente.Ativo,
                dat_cadastro = ingrediente.DataCadastro,
                nom_ingrediente = ingrediente.NomeIngrediente
            };

            _context.Ingredientes.Add(newIngrediente);
            _context.SaveChanges();

            return string.Empty;
            //throw new NotImplementedException();
        }


    }
}
