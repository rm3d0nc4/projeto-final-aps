using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_final_aps.Models
{
    public abstract class TipoDePagamento
    {
        [Display(Name = "Código"), Key()]
        public int Id { get; set; }
        [Display(Name = "Nome do Cobrado")]
        public string NomeDoCobrado { get; set; } = string.Empty;
        [Display(Name = "Informações Adicionais")]
        public string InformacoesAdicionais { get; set; } = string.Empty;
    }
}