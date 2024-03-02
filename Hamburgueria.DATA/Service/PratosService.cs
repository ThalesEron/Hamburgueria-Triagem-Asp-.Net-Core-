using Hamburgueria.DATA.Interfaces;

namespace Hamburgueria.DATA.Service
{
    public class PratosService
    {
        private readonly IPratosRepository _pratosRepository;

        public PratosService(IPratosRepository pratosRepository)
        {
            _pratosRepository = pratosRepository;
        }
    }
}
