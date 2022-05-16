using Microsoft.EntityFrameworkCore;
using StudentFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFinder.DataAccess
{
    public class StudentDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-BON6IIF;Database=StudentDb;Trusted_Connection=true;");
        }

        public DbSet<Student> students { get; set; }
    }
}
