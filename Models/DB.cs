using Microsoft.EntityFrameworkCore;

namespace EdumindAkademia.Models
{
    public class DB : DbContext
    {

        public DB(DbContextOptions<DB> context) : base(context)
        {

        }


        //2. percaktimi i modeleve qe do te jene tabela ne DB
        public DbSet<Produktet> Produktet { get; set; }
        public DbSet<Kategorite> Kategorite { get; set; }

    }
}
