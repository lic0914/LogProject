using LogProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogProject
{
    public class LogContext:DbContext
    {
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("server=.;database=log4netdb;integrated security=true");

        // }
       public LogContext(DbContextOptions<LogContext> opt):base(opt)
       {
           Database.EnsureCreated();
       }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Log>().ToTable("LogInfos").HasKey(e => e.Date);
            modelBuilder.ApplyConfiguration(new LogConfig());
                base.OnModelCreating(modelBuilder);
        }
        public DbSet<Log> Logs { get; set; }
    }
}
