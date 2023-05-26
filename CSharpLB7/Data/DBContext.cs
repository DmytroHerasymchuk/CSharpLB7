using CSharpLB7.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLB7.Data
{
    public class DBContext : DbContext
    {
        public DBContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=DESKTOP-2JE9GPK;Initial Catalog=Lb7DB;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<Lesson> Disciplines { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}