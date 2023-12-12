using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_final_aps.Models
{
    public class Item
    {
        [Display(Name = "Código"), Key()]
        public int Id { get; set; }
        [Display(Name = "Preço")]
        public double Preco { get; set; }
        [Display(Name = "Percentual")]
        public int Percentual { get; set; }
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
        [Display(Name = "Produto")]
        public Produto? Produto { get; set; }
        [Display(Name = "Produto"), Required(), ForeignKey("Produto")]
        public int ProdutoId { get; set; }
    }
}