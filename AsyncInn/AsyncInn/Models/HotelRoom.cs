﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class HotelRoom
    {
        [ForeignKey("Hotel")]
        public int HotelID { get; set; }
        public int RoomNumber { get; set; }
        [ForeignKey ("Room")]
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Please provide a nightly rate")]
        [Display(Name = "Nightly Rate")]
        public decimal Rate { get; set; }

        [Required(ErrorMessage = "Please indicate pet friendliness")]
        [Display(Name = "Pet friendly?")]
        public bool PetFriendly { get; set; }

        //Navigation Properties
        public Hotel Hotel { get; set; }
        public Room Room { get; set; }
    }
}
