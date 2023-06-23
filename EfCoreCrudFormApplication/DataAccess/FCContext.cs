using EfCoreCrudFormApplication.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreCrudFormApplication.DataAccess
{
    public class FCContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
          optionsBuilder.UseSqlServer
    ("Server=SELIMBAYINDIR\\ARCHITECTURE;Database=ddd;User Id=sa;Password=Perkon123456; TrustServerCertificate=True;");
   
        }
        public DbSet<Person> People{ get; set; }
    }
}
