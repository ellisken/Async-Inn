using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IAmenities
    {

        //Create
        Task CreateAmenity(Amenities amenity);

        //Read
        Task<List<Amenities>> GetAmenities();
        Task<Amenities> GetAmenity(int? id);

        //Update
        Task UpdateAmenity(Amenities amenity);

        //Delete
        Task DeleteAmenity(int id);


    }
}
