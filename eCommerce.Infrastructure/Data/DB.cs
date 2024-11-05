using eCommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Infrastructure.Data
{
    public class DB : DbContext
    {

        public DB(DbContextOptions<DB> context) : base(context)
        {

        }


        //2. percaktimi i modeleve qe do te jene tabela ne DB
        public DbSet<Produktet> Produktet { get; set; }
        public DbSet<Kategorite> Kategorite { get; set; }
        public DbSet<Komentet> Komentet { get; set; }

    }
}
