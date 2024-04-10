using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.IO;
using System.Linq;
using ClassLibrary_Konyv.models;
using BookLibrary.Data;

public class Program : KonyvContext
{

    static void Main(string[] args)
    {
        using (var context = new KonyvContext())
        {
            if (!context.models_class.Any())
            {
                string[] sorok = File.ReadAllLines(@"C:\\Adat\\konyv.csv");

                foreach (var sor in sorok.Skip(1))
                {
                    var values = sor.Split(',');
                    var book = new models_class(values[0], values[1], int.Parse(values[2]), int.Parse(values[3]));
                    context.models_class.Add(book);
                }
                context.SaveChanges();
            }

            foreach (var book in context.models_class)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }
}

    namespace Konyv.Data
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

