using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Models
{
    [Table("tb_ingrediente")]
    public class IngredienteDto
    {
        [Key]
        public int ingrediente_id { get; set; }
        public string nom_ingrediente { get; set; }
        public bool ind_ativo { get; set; }
        public DateTime dat_cadastro { get; set; }
    }
}
