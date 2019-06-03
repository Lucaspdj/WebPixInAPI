using Microsoft.EntityFrameworkCore;
using Entity;

namespace WebPixRepository
{
    public class WebPixInContext : DbContext
    {
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<MotorAux> MotorAux { get; set; }
        public DbSet<Acao> Acao { get; set; }
        public DbSet<Parametro> Parametro { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=35.198.27.36;Initial Catalog=WpIn;Persist Security Info=True;User ID=Dev;Password=WebPix@123;");
        }
    }
}
