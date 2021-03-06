﻿using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class HotelService : IHotel
    {
        private AsyncInnDbContext _context;

        public HotelService(AsyncInnDbContext context)
        {
            _context = context;
        }

        //Create hotel
        public async Task CreateHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);
            await _context.SaveChangesAsync();
        }

        //Delete hotel
        public async Task DeleteHotel(int id)
        {
            Hotel hotel = await GetHotel(id);
            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();
        }

        //Get specific hotel
        public async Task<Hotel> GetHotel(int? id)
        {
            return await _context.Hotels.FirstOrDefaultAsync(x => x.ID == id);
        }

        //Get list of all hotels
        public async Task<List<Hotel>> GetHotels()
        {
            return await _context.Hotels.ToListAsync();
        }

        //Update a hotel
        public async Task UpdateHotel(Hotel hotel)
        {
            _context.Hotels.Update(hotel);
            await _context.SaveChangesAsync();
        }
    }
}
