using Microsoft.EntityFrameworkCore;
using ControlePonto.Models;

namespace ControlePonto.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<BatidaPonto> BatidasPonto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=controleponto.db");
        }
    }
}
