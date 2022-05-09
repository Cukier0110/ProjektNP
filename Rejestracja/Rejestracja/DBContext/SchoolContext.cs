using Microsoft.EntityFrameworkCore;
using Rejestracja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejestracja.DBContext
{
    public class SchoolContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<StudyGroup> StudyGroups { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SchoolDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
