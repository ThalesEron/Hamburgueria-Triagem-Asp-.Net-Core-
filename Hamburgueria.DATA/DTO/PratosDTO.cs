using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Hamburgueria.DATA.DTO
{
    public class PratosDTO
    {
        public int Codigo { get; set; }
        [DisplayName("Valor Prato")]

        public decimal ValorPrato { get; set; }
        [DisplayName("Valor Promocional")]
        public decimal ValorPratoPromocional { get; set; }
        [DisplayName("Nome Prato")]
        public string NomePrato { get; set; }
        [DisplayName("Data Cadastro")]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }
    }
}
