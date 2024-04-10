using ClassLibrary_Konyv.models;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Data
{
    public class KonyvContext : DbContext
    {
        public DbSet<models_class> models_class { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connMySql = "Server=127.0.0.1;User ID=root;Password=;Database=CegNyilvantartas";

            optionsBuilder.UseSqlServer(connMySql);
        }
    }
}