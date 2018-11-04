using AsyncInn.Data;
using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace UnitTestAsyncInn
{
    public class UnitTest1
    {
        //Test GetAmenityName
        [Fact]
        public void GetAmenityName()
        {
            Amenities a = new Amenities();
            a.Name = "Air Conditioning";
            Assert.Equal("Air Conditioning", a.Name);
        }

        //Test SetAmenityName
        [Fact]
        public void SetAmenityName()
        {
            Amenities a = new Amenities();
            a.Name = "Balcony";
            a.Name = "Coffee Machine";
            Assert.Equal("Coffee Machine", a.Name);
        }

        //Test get/set Hotel Name, Address, Phone
        [Fact]
        public void GetHotelName()
        {
            Hotel h = new Hotel();
            h.Name = "Seattle";
            Assert.Equal("Seattle", h.Name);
        }

        //Test set Hotel name
        [Fact]
        public void SetHotelName()
        {
            Hotel h = new Hotel();
            h.Name = "Seattle";
            h.Name = "Snoqualmie";
            Assert.Equal("Snoqualmie", h.Name);
        }

        //Test get hotel address
        [Fact]
        public void GetHotelAddress()
        {
            Hotel h = new Hotel();
            h.Address = "123 Main St.";
            Assert.Equal("123 Main St.", h.Address);
        }

        //Test set hotel address
        [Fact]
        public void SetHotelAddress()
        {
            Hotel h = new Hotel();
            h.Address = "123 Main St.";
            h.Address = "1805 NW Market St.";
            Assert.Equal("1805 NW Market St.", h.Address);
        }

        //Test get hotel phone
        [Fact]
        public void GetHotelPhone()
        {
            Hotel h = new Hotel();
            h.Phone = "1234567";
            Assert.Equal("1234567", h.Phone);
        }

        //Test set hotel phone
        [Fact]
        public void SetHotelPhone()
        {
            Hotel h = new Hotel();
            h.Phone = "9876543";
            h.Phone = "1234567";
            Assert.Equal("1234567", h.Phone);
        }


        //Test get Room Name
        [Fact]
        public void GetRoomName()
        {
            Room r = new Room();
            r.Name = "Seahawks Suite";
            Assert.Equal("Seahawks Suite", r.Name);
        }

        //Test set Room Name
        [Fact]
        public void SetRoomName()
        {
            Room r = new Room();
            r.Name = "Basic Economy";
            r.Name = "Seahawks Suite";
            Assert.Equal("Seahawks Suite", r.Name);
        }

        //Test get room layout
        [Fact]
        public void GetRoomLayout()
        {
            Room r = new Room();
            r.Name = "Basic";
            r.Layout = Layout.Studio;
            Assert.Equal(Layout.Studio, r.Layout);
        }

        //Test set room layout
        [Fact]
        public void SetRoomLayout()
        {
            Room r = new Room();
            r.Name = "test room";
            r.Layout = Layout.Studio;
            r.Layout = Layout.OneBedroom;
            Assert.Equal(Layout.OneBedroom, r.Layout);
        }

        //Test get HotelRoom RoomNumber
        [Fact]
        public void GetHRNumber()
        {
            HotelRoom hr = new HotelRoom();
            hr.RoomNumber = 123;
            Assert.Equal(123, hr.RoomNumber);
        }

        //Test set HotelRoom RoomNumber
        [Fact]
        public void SetHRNumber()
        {
            HotelRoom hr = new HotelRoom();
            hr.RoomNumber = 456;
            hr.RoomNumber = 123;
            Assert.Equal(123, hr.RoomNumber);
        }

        //Test Get HotelRoom Rate
        [Fact]
        public void GetHRRate()
        {
            HotelRoom hr = new HotelRoom();
            hr.Rate = 250.97M;
            Assert.Equal(250.97M, hr.Rate);
        }

        //Test Set HotelRoom Rate
        [Fact]
        public void SetHRRate()
        {
            HotelRoom hr = new HotelRoom();
            hr.Rate = 350.12M;
            hr.Rate = 250.97M;
            Assert.Equal(250.97M, hr.Rate);
        }
        
        //Test get hotelroom petfriendly
        [Fact]
        public void GetHRPet()
        {
            HotelRoom hr = new HotelRoom();
            hr.PetFriendly = true;
            Assert.True(hr.PetFriendly);
        }

        //Test set hotelroom petfriendly
        [Fact]
        public void SetHRPet()
        {
            HotelRoom hr = new HotelRoom();
            hr.PetFriendly = false;
            hr.PetFriendly = true;
            Assert.True(hr.PetFriendly);
        }

        //Test Create and Read Amenity
        [Fact]
        public async void CreateAmenityDB()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("CreateAmenity")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                //Arrange - create amenity and assign values
                Amenities a = new Amenities();
                a.Name = "AC";
                context.Amenities.Add(a);
                context.SaveChanges();

                //Act
                var amenity = await context.Amenities.FirstOrDefaultAsync(x => x.Name == a.Name);

                //Assert - grab from db and assert entry
                Assert.Equal(amenity.Name, a.Name);
            }
        }

        //Test Update Amenity
        [Fact]
        public async void UpdateAmenityDB()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("UpdateAmenity")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                //Arrange - create amenity and assign values
                Amenities a = new Amenities();
                a.Name = "AC";
                context.Amenities.Add(a);
                context.SaveChanges();

                //Act
                var amenity = await context.Amenities.FirstOrDefaultAsync(x => x.Name == a.Name);

                amenity.Name = "Balcony";
                int id = amenity.ID;

                var updatedAmenity = await context.Amenities.FirstOrDefaultAsync(x => x.ID == id);

                //Assert - grab from db and assert entry
                Assert.Equal("Balcony", updatedAmenity.Name);
            }
        }

        //Test Delete Amenity
        [Fact]
        public async void DeleteAmenityDB()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("DeleteAmenity")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                //Arrange - create amenity and assign values
                Amenities a = new Amenities();
                a.Name = "AC";
                context.Amenities.Add(a);
                context.SaveChanges();

                //Act
                var amenity = await context.Amenities.FirstOrDefaultAsync(x => x.Name == a.Name);
                int id = amenity.ID;

                context.Amenities.Remove(amenity);
                await context.SaveChangesAsync();

                var deletedAmenity = await context.Amenities.FirstOrDefaultAsync(x => x.ID == id);

                //Assert - grab from db and assert entry
                Assert.Null(deletedAmenity);
            }
        }

        //Test CRUD Hotel
        //Test Create and Read Hotel
        [Fact]
        public async void CreateHotelDB()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("CreateHotel")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                //Arrange - create hotel and assign values
                Hotel h = new Hotel();
                h.Name = "Seattle";
                context.Hotels.Add(h);
                context.SaveChanges();

                //Act
                var hotel = await context.Hotels.FirstOrDefaultAsync(x => x.Name == h.Name);

                //Assert - grab from db and assert entry
                Assert.Equal(hotel.Name, h.Name);
            }
        }

        //Test Update Hotel
        [Fact]
        public async void UpdateHotelDB()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("UpdateHotel")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                //Arrange - create hotel and assign values
                Hotel h = new Hotel();
                h.Name = "Seattle";
                context.Hotels.Add(h);
                context.SaveChanges();

                //Act
                var hotel = await context.Hotels.FirstOrDefaultAsync(x => x.Name == h.Name);

                hotel.Name = "Bellevue";
                int id = hotel.ID;

                var updatedHotel = await context.Hotels.FirstOrDefaultAsync(x => x.ID == id);

                //Assert - grab from db and assert entry
                Assert.Equal("Bellevue", updatedHotel.Name);
            }
        }

        //Test Delete Hotel
        [Fact]
        public async void DeleteHotelDB()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("DeleteHotel")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                //Arrange - create hotel and assign values
                Hotel h = new Hotel();
                h.Name = "Seattle";
                context.Hotels.Add(h);
                context.SaveChanges();

                //Act
                var hotel = await context.Hotels.FirstOrDefaultAsync(x => x.Name == h.Name);
                int id = hotel.ID;

                context.Hotels.Remove(hotel);
                await context.SaveChangesAsync();

                var deletedHotel = await context.Hotels.FirstOrDefaultAsync(x => x.ID == id);

                //Assert - grab from db and assert entry
                Assert.Null(deletedHotel);
            }
        }


        //Test CRUD Room
        [Fact]
        public async void CreateRoomDB()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("CreateRoom")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                //Arrange - create hotel and assign values
                Room r = new Room();
                r.Name = "economy";
                context.Rooms.Add(r);
                context.SaveChanges();

                //Act
                var room = await context.Rooms.FirstOrDefaultAsync(x => x.Name == r.Name);

                //Assert - grab from db and assert entry
                Assert.Equal(room.Name, r.Name);
            }
        }

        //Test Update Hotel
        [Fact]
        public async void UpdateRoomDB()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("UpdateRoom")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                //Arrange - create hotel and assign values
                Room r = new Room();
                r.Name = "economy";
                context.Rooms.Add(r);
                context.SaveChanges();

                //Act
                var room = await context.Rooms.FirstOrDefaultAsync(x => x.Name == r.Name);

                room.Name = "deluxe";
                int id = room.ID;

                var updatedRoom = await context.Rooms.FirstOrDefaultAsync(x => x.ID == id);

                //Assert - grab from db and assert entry
                Assert.Equal("deluxe", updatedRoom.Name);
            }
        }

        //Test Delete Hotel
        [Fact]
        public async void DeleteRoomDB()
        {
            DbContextOptions<AsyncInnDbContext> options =
            new DbContextOptionsBuilder<AsyncInnDbContext>()
            .UseInMemoryDatabase("DeleteRoom")
            .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                //Arrange - create hotel and assign values
                Room r = new Room();
                r.Name = "economy";
                context.Rooms.Add(r);
                context.SaveChanges();

                //Act
                var room = await context.Rooms.FirstOrDefaultAsync(x => x.Name == r.Name);

                int id = room.ID;

                context.Rooms.Remove(room);
                await context.SaveChangesAsync();

                var deletedRoom = await context.Rooms.FirstOrDefaultAsync(x => x.ID == id);

                //Assert - grab from db and assert entry
                Assert.Null(deletedRoom);
            }
        }
        //Test CRUD HotelROom
        //Test CRUD RoomAmenities

    }
}
