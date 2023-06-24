using EfCoreCrudFormApplication.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreCrudFormApplication.DataAccess
{
    public class FCContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            BaseCon(optionsBuilder);


            // WorkCon(optionsBuilder);


        }

        private static void BaseCon(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer
       ("Server=SELIMBAYINDIR\\ARCHITECTURE;Database=BaseFormDb;User Id=sa;Password=Perkon123456; TrustServerCertificate=True;");
        }

        private static void WorkCon(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer
       ("Server=SELIM-BAYINDIR\\BYNDR;Database=sa;User Id=sa;Password=Perkon123456; TrustServerCertificate=True;");
        }



        public DbSet<Person> People { get; set; }
    }
}
