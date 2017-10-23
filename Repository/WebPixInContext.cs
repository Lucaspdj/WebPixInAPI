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
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-9B04LJT\SQLEXPRESS;Database=WebPixIn;Trusted_Connection=True;Integrated Security = True;");
            optionsBuilder.UseSqlServer(@"Server = 187.84.229.35; Database = WebPixIn; User Id = dev;Password =Lucas-2007");
        }
    }
}
