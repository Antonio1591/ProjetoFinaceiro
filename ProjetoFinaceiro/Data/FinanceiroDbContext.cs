using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using ProjetoFinaceiro.Modelo;
using ProjetoFinaceiro.Services;

namespace ProjetoFinaceiro.Data
{
    public class FinanceiroDbContext : DbContext
    {

        public FinanceiroDbContext(DbContextOptions<FinanceiroDbContext> options) : base(options) { }
        public DbSet<Tipos> Tipos { get; set; }
        public DbSet<EntradaFinaceira> EntradaFinaceira { get; set; }
        public DbSet<SaidaFinaceira> SaidaFinaceira { get; set; }
        public DbSet<MovimentoFinaceiro> MovimentoFinaceiro { get; set; }

    }
}
