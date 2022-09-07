using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using ProjetoFinaceiro.Modelo;

namespace ProjetoFinaceiro.Data
{
    public class FinanceiroDbContext : DbContext
    {
       
        public FinanceiroDbContext(DbContextOptions<FinanceiroDbContext> options) : base(options) { }
        public DbSet<Tipos> Tipos { get; set; }
       

    }

}
