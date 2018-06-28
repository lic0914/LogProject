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
        //     optionsBuilder.UseSqlServer("server=39.104.87.16;database=log4netdb;uid=sa;pwd=Lic123456");

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
