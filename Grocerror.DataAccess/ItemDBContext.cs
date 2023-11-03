using Grocerror.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocerror.DataAccess
{
    public class ItemDBContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server = localhost; Database = GroceryItems; User Id = sa; Password = Rs@19980504; TrustServerCertificate = true";
            optionsBuilder.UseSqlServer(connectionString);  
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(new Item[]
            {
                new Item
                {
                    Id = 1,
                    ItemName = "Milk from DB",
                    ListId = 1,
                    Date = DateTime.Now,
                    Status = ItemStatus.Got
                },
                new Item
                {
                    Id = 2,
                    ItemName = "Coffeee new from DB",
                    ListId = 2,
                    Date = DateTime.Now,
                    Status = ItemStatus.Got
                }
                
            });
        }
    }
}
