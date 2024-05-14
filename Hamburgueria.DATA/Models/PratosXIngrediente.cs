using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Models;
public class PratosXIngrediente : BaseModel
{
	[Key]
	[Column("pratoxingrediente_id")]
	[Required]
	public int Codigo { get; set; }

	[Column("ind_ativo")]
	[Required]
	public bool Ativo { get; set; }

	[Column("pratos_id")]
	[Required]
	public int PratosCodigo { get; set; }

	[Column("ingrediente_id")]
	[Required]
	public int IngredienteCodigo { get; set; }


}
