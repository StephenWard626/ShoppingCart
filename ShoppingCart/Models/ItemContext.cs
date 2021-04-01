using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    //Adding a Database
    //NuGet Packages - Microsoft.EntityFrameworkCore and SQLServer
    public class ItemContext : DbContext
    {
        public DbSet<Item> Items {get; set; }

        private const string connectionString =
            "Server=(localdb)\\mssqllocaldb;DataBase=Items;Trusted_Connection=False;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);

        }
    }
}
