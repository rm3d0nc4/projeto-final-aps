using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_final_aps.Models
{
    public class Marca
    {
        [Display(Name = "Código"), Key()]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string Nome { get; set; } = string.Empty;
        [Display(Name = "Descrição")]
        public string Descricao { get; set; } = string.Empty;
        [Display(Name = "Produtos")]
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();
    }
}