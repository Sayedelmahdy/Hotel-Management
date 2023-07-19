using Hotel_Manager.Entities.FrontEnd;
using Hotel_Manager.Entities.FrontEnd.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Manager
{
    public class FRONTEND_RESERVATION : DbContext
    {
        public virtual DbSet<reservation> reservation { get; set; }
        public virtual DbSet<checkinnosupply> checkinnosupply { get; set; }
        public virtual DbSet<ShowAllReservation> ShowAllReservation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["frontend_reservation_cs"].ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<reservation>
                (
                    Ep=>
                    {
                        Ep.HasKey(S => S.Id);
                        Ep.Property(S => S.Id).IsRequired().UseIdentityColumn(1011,1);
                        Ep.Property(S => S.number_guest).HasDefaultValue(0);
                        Ep.Property(S => S.total_bill).HasDefaultValue(0);
                        Ep.Property(S => S.arrival_time).HasDefaultValue(DateTime.Now);
                        Ep.Property(S => S.leaving_time).HasDefaultValue(DateTime.Now);
                        Ep.Property(S => S.check_in).HasDefaultValue(false);
                        Ep.Property(S => S.break_fast).HasDefaultValue(0);
                        Ep.Property(S => S.lunch).HasDefaultValue(0);
                        Ep.Property(S => S.dinner).HasDefaultValue(0);
                        Ep.Property(S => S.cleaning).HasDefaultValue(false);
                        Ep.Property(S => S.towel).HasDefaultValue(false);
                        Ep.Property(S => S.s_surprise).HasDefaultValue(false);
                        Ep.Property(S => S.supply_status).HasDefaultValue(false);
                        Ep.Property(S => S.food_bill).HasDefaultValue(0);
                    }
                );
            modelBuilder.Entity<checkinnosupply>
                (
                    Ep =>
                        {
                            Ep.HasNoKey();
                            Ep.ToView("checkinnosupply");
                        }
                );
            modelBuilder.Entity<ShowAllReservation>
               (
                   Ep =>
                   {
                       Ep.HasNoKey();
                       Ep.ToView("ShowAllReservation");
                   }
               );
            base.OnModelCreating(modelBuilder);
        }
        

    }
}
