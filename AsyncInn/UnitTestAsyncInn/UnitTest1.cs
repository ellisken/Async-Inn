using AsyncInn.Models;
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

        //Test CRUD Amenity
        //Test CRUD Hotel
        //Test CRUD Room
        //Test CRUD HotelROom
        //Test CRUD RoomAmenities

    }
}
