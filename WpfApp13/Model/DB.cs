using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;


namespace WpfApp13.Model
{
    public class DB: DbContext
    {
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }

        public DB()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("server=192.168.200.13;userid=student;password=student;database=WEB_U_REZKO", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.3.39-mariadb"));
        }
    }

    
}
