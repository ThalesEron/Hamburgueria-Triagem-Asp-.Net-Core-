using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgueria.DATA.Models
{
    [Table("tb_pedido")]
    public class Pedido
    {
        [Key]
        [Column("id")]
        [Required]
        public int Codigo { get; set; }

        [Column("num_valor")]
        [Required]
        public decimal ValorPedido { get; set; }

        [Column("num_mesa")]
        [Required]
        public int NumeroMesa { get; set; }

        [Column("nom_cliente")]
        [Required]
        public string NomeCliente { get; set; }

        [Column("ind_ativo")]
        [Required]
        public bool Ativo { get; set; }

        [Column("dat_cadastro")]
        [Required]
        public DateTime DataCadastro { get; set; }

    }
}

