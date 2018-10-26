﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Amenities
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please provide an amenity description")]
        [Display(Name = "Amenity")]
        public string Name { get; set; }

        //Navigation Properties
        public ICollection<RoomAmenities> Rooms { get; set; }
    }
}
