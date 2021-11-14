using EFDataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLibrary.DataAccess
{
   public class DataContext  : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Student> Students { get; set; }

        public DbSet<Countries> CountryName { get; set; }

        public DbSet<Classes> Class_Name { get; set; }
    }
}
