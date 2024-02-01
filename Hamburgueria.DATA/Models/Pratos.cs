using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Models;
public class Pratos : BaseModel
{
    public decimal Valor { get; set; }
    public decimal ValorPromocional { get; set; }
}
