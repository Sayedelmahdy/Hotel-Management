using Hotel_Manager.Entities.FrontEnd;
using Hotel_Manager.Entities.Login;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager
{
    public class LOGIN_MANAGER:DbContext
    {
        public virtual DbSet<frontend> frontend { get; set; }
        public virtual DbSet<kitchen> kitchen { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings
                ["login_cs"].ConnectionString).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<frontend>
               (
                   Ep =>
                   {
                       Ep.HasKey(S => S.user_name);
                       Ep.Property(S => S.user_name).IsRequired();
                   }
               );
            modelBuilder.Entity<kitchen>
               (
                   Ep =>
                   {
                       Ep.HasKey(S => S.user_name);
                       Ep.Property(S => S.user_name).IsRequired();
                   }
               );
            base.OnModelCreating(modelBuilder);
        }


    }
}
