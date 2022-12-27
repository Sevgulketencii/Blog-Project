using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApi.DataAccesLayer
{
    public class Context:DbContext
    {
        public DbSet<Yazarlar> yazarDb { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KCH0A99;database=api;integrated security=true");
        }
    }
}
