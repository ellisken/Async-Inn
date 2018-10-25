using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Room
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Layout { get; set; }

        //Navigation Properties
        public ICollection<RoomAmenities> Amenities { get; set; }
        public ICollection<HotelRoom> Hotels { get; set; }
    }

    public enum Layout
    {
        Studio = 1,
        OneBedroom,
        TwoBedroom
    }
}
