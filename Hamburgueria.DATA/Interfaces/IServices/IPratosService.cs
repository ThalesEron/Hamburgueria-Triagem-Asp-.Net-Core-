using Hamburgueria.DATA.Models;

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
        void CadastrarPratosXIngrediente(PratosXIngrediente pratosXIngrediente);
    }
}
