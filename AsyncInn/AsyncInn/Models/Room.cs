using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Room
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter the room name")]
        [Display(Name = "Room Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please select a layout")]
        [EnumDataType(typeof(Layout))]
        public Layout Layout { get; set; }

        //Navigation Properties
        public ICollection<RoomAmenities> Amenities { get; set; }
        public ICollection<HotelRoom> Hotels { get; set; }
    }

    public enum Layout
    {
        [Display(Name = "Studio")]
        Studio = 1,
        [Display(Name = "1 Bedroom")]
        OneBedroom,
        [Display(Name = "2 Bedroom")]
        TwoBedroom
    }
}
