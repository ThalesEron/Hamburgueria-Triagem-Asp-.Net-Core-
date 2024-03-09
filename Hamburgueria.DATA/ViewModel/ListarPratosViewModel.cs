using Hamburgueria.DATA.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.ViewModel
{
    public class ListarPratosViewModel
    {
        public IList<PratosDTO> PratosL { get; set; } = new List<PratosDTO>();
        public PratosDTO Prato { get; set; }
    }
}
