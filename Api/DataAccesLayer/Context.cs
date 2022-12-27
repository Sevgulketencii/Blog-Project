using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.DataAccesLayer
{
    public class Context:DbContext
    {
        public DbSet<Yazar> yazarDb { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KCH0A99;database=api;integrated security=true");
        }
    }
}
