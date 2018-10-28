using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data
{
    public class AsyncInnDbContext : DbContext
    {
        public AsyncInnDbContext(DbContextOptions<AsyncInnDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelRoom>().HasKey(
                hr => new { hr.HotelID, hr.RoomNumber }
                );

            modelBuilder.Entity<RoomAmenities>().HasKey(
                ra => new { ra.AmenitiesID, ra.RoomID }
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    ID = 1,
                    Name = "Belltown",
                    Address = "123 3rd Ave.",
                    Phone = "206-123-4567"
                },
                new Hotel
                {
                    ID = 2,
                    Name = "Bellevue",
                    Address = "123 Main St.",
                    Phone = "425-123-4567"
                 },
                 new Hotel
                 {
                    ID = 3,
                    Name = "University District",
                    Address = "4567 NE 50th St.",
                    Phone = "206-891-2345"
                 },
                 new Hotel
                 {
                     ID = 4,
                     Name = "Ballard",
                     Address = "8910 NW Market St.",
                     Phone = "206-678-9123"
                 },
                 new Hotel
                  {
                      ID = 5,
                      Name = "Portland",
                      Address = "123 Naito Way",
                      Phone = "503-123-4567"
                  },
                  new Hotel
                  {
                      ID = 6,
                      Name = "Bellingham",
                      Address = "1234 Chuckanut Way",
                      Phone = "360-123-4567"
                  }
            );

            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    ID = 1,
                    Name = "Cascade",
                    Layout = Layout.OneBedroom
                },
                new Room
                {
                    ID = 2,
                    Name = "Chinook",
                    Layout = Layout.Studio
                },
                new Room
                {
                    ID = 3,
                    Name = "Rose",
                    Layout = Layout.OneBedroom
                },
                new Room
                {
                    ID = 4,
                    Name = "Rainier Suite",
                    Layout = Layout.TwoBedroom
                },
                new Room
                {
                    ID = 5,
                    Name = "Puget",
                    Layout = Layout.Studio
                },
                new Room
                {
                    ID = 6,
                    Name = "Salish",
                    Layout = Layout.OneBedroom
                }
            );

            modelBuilder.Entity<Amenities>().HasData(
                new Amenities
                {
                    ID = 1,
                    Name = "Air Conditioning"
                },
                new Amenities
                {
                    ID = 2,
                    Name = "Coffee Maker"
                },
                new Amenities
                {
                    ID = 3,
                    Name = "City View",
                },
                new Amenities
                {
                    ID = 4,
                    Name = "Jacuzzi Bathtub"
                },
                new Amenities
                {
                    ID = 5,
                    Name = "Fireplace"
                }
            );
        }

        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
    }
}
