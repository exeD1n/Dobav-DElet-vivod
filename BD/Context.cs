using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp48.BD
{
    class Context : DbContext
    {
        public string path = "Server=192.168.10.134; database=LutaevDD; user id=stud; password=stud;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(path);
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
