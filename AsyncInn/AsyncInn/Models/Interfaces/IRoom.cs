using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IRoom
    {
        //Create
        Task CreateRoom(Room room);

        //Read
        Task<List<Room>> GetRooms();
        Task<Room> GetRoom(int? id);

        //Update
        Task UpdateRoom(Room room);

        //Delete
        Task DeleteRoom(int id);
    }
}
