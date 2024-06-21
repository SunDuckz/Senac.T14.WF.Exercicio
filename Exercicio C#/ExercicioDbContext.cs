using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;

namespace Exercicio_C_
{
    internal class ExercicioDbContext : DbContext
    {
        public DbSet<Usuarios> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=exercicio.db");
        }
    }
}
