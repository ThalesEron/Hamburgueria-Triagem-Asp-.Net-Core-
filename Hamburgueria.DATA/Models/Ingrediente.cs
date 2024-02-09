using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Models;

public class Ingrediente : BaseModel
{
    public string NomeIngrediente { get; set; }

}
