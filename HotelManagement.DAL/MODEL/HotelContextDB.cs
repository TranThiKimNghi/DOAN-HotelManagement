using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace HotelManagement.DAL.MODEL
{
    public partial class HotelContextDB : DbContext
    {
        public HotelContextDB()
            : base("name=HotelContextDB")
        {
        }

        public virtual DbSet<BookingDetail> BookingDetails { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomType> RoomTypes { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }
        public virtual DbSet<ServiceUsage> ServiceUsages { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookingDetail>()
                .Property(e => e.RoomPrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Booking>()
                .Property(e => e.TotalAmount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Payment>()
                .Property(e => e.Amount)
                .HasPrecision(10, 2);

            modelBuilder.Entity<RoomType>()
                .Property(e => e.BasePrice)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Service>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ServiceUsage>()
                .Property(e => e.Price)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ServiceUsage>()
                .Property(e => e.TotalAmount)
                .HasPrecision(10, 2);
        }
    }
}
