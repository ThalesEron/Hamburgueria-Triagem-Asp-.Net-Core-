using Hamburgueria.DATA.Interfaces;
using Hamburgueria.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Service
{
    public class IngredienteService
    {

        IIngredienteRepository repository;



        public string CadastrarIngrediente(Ingrediente ingrediente)
        {

            repository.CadastrarIngrediente(ingrediente);

            return string.Empty;
        }



    }
}
