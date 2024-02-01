using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Models;
public class PratosXIngrediente : BaseModel
{
    public Pratos Pratos { get; set; }  
    public Ingrediente Ingrediente { get; set; }

}
