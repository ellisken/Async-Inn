using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class RoomService : IRoom
    {
        private AsyncInnDbContext _context;


        public RoomService(AsyncInnDbContext context)
        {
            _context = context;
        }

        //Create room
        public async Task CreateRoom(Room room)
        {
            _context.Rooms.Add(room);
            await _context.SaveChangesAsync();
        }

        //Delete room
        public async Task DeleteRoom(int id)
        {
            Room room = await GetRoom(id);
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();
        }

        //Get a room by ID
        public async Task<Room> GetRoom(int? id)
        {
            return await _context.Rooms.FirstOrDefaultAsync(x => x.ID == id);
        }

        //Get list of all rooms
        public async Task<List<Room>> GetRooms()
        {
            return await _context.Rooms.ToListAsync();
        }

        //Update room
        public async Task UpdateRoom(Room room)
        {
            _context.Rooms.Update(room);
            await _context.SaveChangesAsync();
        }
    }
}
