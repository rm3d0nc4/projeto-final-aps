using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_final_aps.Models
{
    public class PagamentoComCartao : TipoDePagamento
    {
        [Display(Name = "Número do Cartão")]
        public string NumeroDoCartao { get; set; } = string.Empty;
        [Display(Name = "Bandeira")]
        public string Bandeira { get; set; } = string.Empty;
    }
}