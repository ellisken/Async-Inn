using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IHotel
    {
        //Create
        Task CreateHotel(Hotel hotel);

        //Read
        Task<List<Hotel>> GetHotels();
        Task<Hotel> GetHotel(int? id);

        //Update
        Task UpdateHotel(Hotel hotel);

        //Delete
        Task DeleteHotel(int id);
    }
}
