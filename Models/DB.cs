using Microsoft.EntityFrameworkCore;

namespace EdumindAkademia.Models
{
    public class DB : DbContext
    {

        //1. percaktimi i Conn Stringut
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-PAMUBVM\\SQLEXPRESS;Database=eCommerceDB;User ID=sa;Password=sa;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            //optionsBuilder.UseLazyLoadingProxies();
            
        }


        //2. percaktimi i modeleve qe do te jene tabela ne DB
        public DbSet<Produktet> Produktet { get; set; }
        public DbSet<Kategorite> Kategorite { get; set; }

    }
}
