using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlite_mtm_winform_demo
{
    public class MyContext : DbContext
    {
        //Define tables that we want to use
        //Note: Below the "Merchants", "Wares",... become table names in DB
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Ware> Wares { get; set; }
        public DbSet<MerchantHasWares> MerchantHasWares { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Define .db location/name
            optionsBuilder.UseSqlite("Data Source=MySample.db");
            
            //Lazy loading proxies
            optionsBuilder.UseLazyLoadingProxies();
        }

        //Custom defining needed for M-T-M table with additional columns:
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Merchant>()
                .HasMany(wa => wa.Wares)
                .WithMany(me => me.Merchants)
                .UsingEntity<MerchantHasWares>(
                wame => wame.HasOne(x => x.Ware).WithMany().HasForeignKey(x => x.WareId),
                wame => wame.HasOne(x => x.Merchant).WithMany().HasForeignKey(x => x.MerchantID),
                wame =>
                {
                    wame.HasKey(x => new { x.WareId, x.MerchantID });
                }
                );

        }
    }
}
