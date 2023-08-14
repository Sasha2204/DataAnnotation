using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotation
{
    public class MyDbContext:DbContext
    {
        DbSet<Phone> Phones { get; set; }
        DbSet<Country> Countries { get; set; }

        DbSet<Company> Companies { get; set; }

        public MyDbContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PhoneDBPU221;
              Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country[]
                {
                 new Country(){Id=1, Name="UKR",Population=45},
                 new Country(){Id=2, Name="USA",Population=300}
                }
                );
        }
    }
}
