using ControleCaldeiras.Data.Map;
using ControleCaldeiras.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleCaldeiras.Data
{
    public class SistemaCaldeirasDBContex : DbContext
    {
        public SistemaCaldeirasDBContex(DbContextOptions<SistemaCaldeirasDBContex> options)
            : base(options)
        { 
        }

        public DbSet<OperadorModel> Operadores { get; set; }
        public DbSet<CaldeiraModel> Caldeiras { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OperadorMap());
            modelBuilder.ApplyConfiguration(new CaldeiraMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}
