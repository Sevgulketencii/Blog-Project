using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        public DbSet<Hakkimizda> HakkimizdaDb { get; set; }
        public DbSet<Iletisim> IletisimDb { get; set; }
        public DbSet<Kategori> KategoriDb { get; set; }
        public DbSet<Makale> MakaleDb { get; set; }
        public DbSet<Yazarlar> YazarlarDb { get; set; } 
        public DbSet<Yorum> YorumDb { get; set; }
        public DbSet<MailBülteni> MailDb { get; set; }
        public DbSet<Bildirim> BildirimDb { get; set; }
        public DbSet<Mesaj> MesajDb { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-KCH0A99;database=Makale3;integrated security=true");
        }

        protected override void  OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mesaj>().HasOne(x => x.Alici).WithMany(y => y.Alıcı)
                .HasForeignKey(z => z.MesajAlici)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Mesaj>().HasOne(x => x.Gönderen).WithMany(y => y.Gonderen)
                .HasForeignKey(z => z.MesajGönderen)
                .OnDelete(DeleteBehavior.ClientSetNull);

           
        }
     
    }
}
