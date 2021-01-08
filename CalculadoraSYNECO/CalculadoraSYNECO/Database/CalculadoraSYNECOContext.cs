using Microsoft.EntityFrameworkCore;

namespace CalculadoraSYNECO.Database
{
    public class CalculadoraSYNECOContext : DbContext
    {
        public CalculadoraSYNECOContext(DbContextOptions<CalculadoraSYNECOContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(@"Server=DESKTOP-P89NQS8\sql2019;Database=Calculadora;User Id=sa;Password=sql2019$t@;"));
        }
        public DbSet<CalculadoraSYNECO.Models.Calculo> Calculo { get; set; }
    }
}
