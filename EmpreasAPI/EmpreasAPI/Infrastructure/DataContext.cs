using EmpreasAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace EmpreasAPI.Infrastructure
{
    public class DataContext : DbContext
    {
        public DbSet<Empresa> Empresas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BDEmpresas;Integrated Security=True");
        }
    }
}
