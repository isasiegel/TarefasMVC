using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Data.Mapeamento;
using ProjetoMVC.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ProjetoMVC.Data
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            modelBuilder.ApplyConfiguration(new TarefaMapeamento());
        }

        public DbSet<Tarefa> Tarefa { get; set; }
    }
}
