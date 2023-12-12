using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace projeto_final_aps.Models
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; } = null!;
        public DbSet<Vendedor> Vendedores { get; set; } = null!;
        public DbSet<Transportadora> Transportadoras { get; set; } = null!;
        public DbSet<TipoDePagamento> TiposDePagamento { get; set; } = null!;
        public DbSet<PagamentoComCartao> PagamentosComCartao { get; set; } = null!;
        public DbSet<PagamentoComCheque> PagamentosComBoleto { get; set; } = null!;
        public DbSet<Marca> Marcas { get; set; } = null!;
        public DbSet<Produto> Produtos { get; set; } = null!;
        public DbSet<Item> Items { get; set; } = null!;


    }

}