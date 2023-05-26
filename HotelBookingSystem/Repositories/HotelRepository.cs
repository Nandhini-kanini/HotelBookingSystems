using HotelBookingSystem.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagement.Repositories
{
    public class HotelRepository : IHotel
    {
        private readonly HotelContext _hotelContext;

        public HotelRepository(HotelContext con)
        {
            _hotelContext = con;
        }

        public IEnumerable<Hotel> GetHotel()
        {
            try
            {
                return _hotelContext.Hotels.Include(x => x.Rooms).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to retrieve hotels.", ex);
            }
        }

        public Hotel GetHotelById(int HotelId)
        {
            try
            {
                return _hotelContext.Hotels.FirstOrDefault(x => x.HotelId == HotelId);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to retrieve hotel by ID.", ex);
            }
        }

        public Hotel PostHotel(Hotel hotel)
        {
            try
            {
                _hotelContext.Hotels.Add(hotel);
                _hotelContext.SaveChanges();
                return hotel;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create hotel.", ex);
            }
        }

        public Hotel PutHotel(int HotelId, Hotel hotel)
        {
            try
            {
                _hotelContext.Entry(hotel).State = EntityState.Modified;
                _hotelContext.SaveChanges();
                return hotel;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update hotel.", ex);
            }
        }

        public Hotel DeleteHotel(int HotelId)
        {
            try
            {
                var hotel = _hotelContext.Hotels.Find(HotelId);
                _hotelContext.Hotels.Remove(hotel);
                _hotelContext.SaveChanges();
                return hotel;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to delete hotel.", ex);
            }
        }
    }
}
