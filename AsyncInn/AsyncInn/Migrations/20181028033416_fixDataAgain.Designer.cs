﻿// <auto-generated />
using AsyncInn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AsyncInn.Migrations
{
    [DbContext(typeof(AsyncInnDbContext))]
    [Migration("20181028033416_fixDataAgain")]
    partial class fixDataAgain
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AsyncInn.Models.Amenities", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Amenities");

                    b.HasData(
                        new { ID = 1, Name = "Air Conditioning" },
                        new { ID = 2, Name = "Coffee Maker" },
                        new { ID = 3, Name = "City View" },
                        new { ID = 4, Name = "Jacuzzi Bathtub" },
                        new { ID = 5, Name = "Fireplace" }
                    );
                });

            modelBuilder.Entity("AsyncInn.Models.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Hotels");

                    b.HasData(
                        new { ID = 1, Address = "123 3rd Ave.", Name = "Belltown", Phone = "206-123-4567" },
                        new { ID = 2, Address = "123 Main St.", Name = "Bellevue", Phone = "425-123-4567" },
                        new { ID = 3, Address = "4567 NE 50th St.", Name = "University District", Phone = "206-891-2345" },
                        new { ID = 4, Address = "8910 NW Market St.", Name = "Ballard", Phone = "206-678-9123" },
                        new { ID = 5, Address = "123 Naito Way", Name = "Portland", Phone = "503-123-4567" },
                        new { ID = 6, Address = "1234 Chuckanut Way", Name = "Bellingham", Phone = "360-123-4567" }
                    );
                });

            modelBuilder.Entity("AsyncInn.Models.HotelRoom", b =>
                {
                    b.Property<int>("HotelID");

                    b.Property<int>("RoomNumber");

                    b.Property<bool>("PetFriendly");

                    b.Property<decimal>("Rate");

                    b.Property<int>("RoomID");

                    b.HasKey("HotelID", "RoomNumber");

                    b.HasIndex("RoomID");

                    b.ToTable("HotelRooms");
                });

            modelBuilder.Entity("AsyncInn.Models.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Layout");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Rooms");

                    b.HasData(
                        new { ID = 1, Layout = 2, Name = "Cascade" },
                        new { ID = 2, Layout = 1, Name = "Chinook" },
                        new { ID = 3, Layout = 2, Name = "Rose" },
                        new { ID = 4, Layout = 3, Name = "Rainier Suite" },
                        new { ID = 5, Layout = 1, Name = "Puget" },
                        new { ID = 6, Layout = 2, Name = "Salish" }
                    );
                });

            modelBuilder.Entity("AsyncInn.Models.RoomAmenities", b =>
                {
                    b.Property<int>("AmenitiesID");

                    b.Property<int>("RoomID");

                    b.HasKey("AmenitiesID", "RoomID");

                    b.HasIndex("RoomID");

                    b.ToTable("RoomAmenities");
                });

            modelBuilder.Entity("AsyncInn.Models.HotelRoom", b =>
                {
                    b.HasOne("AsyncInn.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AsyncInn.Models.Room", "Room")
                        .WithMany("Hotels")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AsyncInn.Models.RoomAmenities", b =>
                {
                    b.HasOne("AsyncInn.Models.Amenities", "Amenity")
                        .WithMany("Rooms")
                        .HasForeignKey("AmenitiesID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AsyncInn.Models.Room", "Room")
                        .WithMany("Amenities")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
