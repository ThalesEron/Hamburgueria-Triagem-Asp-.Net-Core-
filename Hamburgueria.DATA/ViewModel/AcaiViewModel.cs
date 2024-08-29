using Hamburgueria.DATA.DTO;
using Hamburgueria.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.ViewModel
{

    public class AcaiViewModel
    {
        public IList<AcaiTamanhos> TamanhosL { get; set; } = new List<AcaiTamanhos>();
        public IList<AcaiAdicionais> AdicionaisL { get; set; } = new List<AcaiAdicionais>();
    }
}
