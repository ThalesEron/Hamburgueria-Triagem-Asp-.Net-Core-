using Hamburgueria.DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.DTO
{
	public class PratosXIngredienteDTO
	{
		public int Codigo { get; set; }
		[DisplayName("Prato")]
		public int CodigoPrato { get; set; }
		
		[DisplayName("Ingrediente")]
		public int CodigoIngrediente { get; set; }
		
		public bool Ativo { get; set; }

		public Pratos Pratos { get; set; }
		
		public Ingrediente Ingrediente { get; set; }
	
	}
}
