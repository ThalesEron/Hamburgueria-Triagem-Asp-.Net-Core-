using Hamburgueria.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Interfaces.IServices
{
    public interface IPratosService
    {
        Pratos GetPratoByName(string nomePrato);
        void CadastrarPrato(Pratos prato);
        IList<Pratos> ListarPratos();
        Pratos GetPratoById(int pratoId);
        void DeletarPrato(Pratos prato);
        void EditarPrato(Pratos prato);

    }
}
