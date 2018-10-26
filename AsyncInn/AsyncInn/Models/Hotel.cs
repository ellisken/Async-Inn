using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Hotel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter the hotel's name")]
        [Display(Name = "Hotel Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide an address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a phone number")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        //Navigation Properties
        public ICollection<HotelRoom> Rooms { get; set; }
    }
}
