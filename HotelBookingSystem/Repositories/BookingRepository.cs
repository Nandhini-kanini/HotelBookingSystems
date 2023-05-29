﻿using BigBang.Models;
using HotelBookingSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace BigBang.Repositories
{
    public class BookingRepository : IBooking
    {
        private readonly HotelContext _bookingContext;

        public BookingRepository(HotelContext con)
        {
            _bookingContext = con;
        }

        public IEnumerable<Booking> GetBooking()
        {
            try
            {
                return _bookingContext.Bookings.Include(x => x.Room).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to retrieve bookings.", ex);
            }
        }

        public Booking GetBookingById(int BookingId)
        {
            try
            {
                return _bookingContext.Bookings.FirstOrDefault(x => x.BookingId == BookingId);
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to retrieve booking by ID.", ex);
            }
        }

        public Booking PostBooking(Booking booking)
        {
            try
            {
                var b = _bookingContext.Hotels.Find(booking.Hotel.HotelId);
                booking.Hotel = b;
                var customer = _bookingContext.Customers.Find(booking.Customer.CustomerId);
                booking.Customer = customer;
                var room = _bookingContext.Rooms.Find(booking.Room.RoomId);
                if (room != null)
                {
                    if (room.RoomCount > 0)
                    {
                        room.RoomCount--; 
                        _bookingContext.Entry(room).State = EntityState.Modified; 

                        
                        booking.Room = room;
                    }
                    else
                    {
                        throw new Exception("No available rooms for booking.");
                    }
                }
                else
                {
                    throw new Exception("Invalid room ID.");
                }

                _bookingContext.Add(booking);
                _bookingContext.SaveChanges();
                return booking;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to create booking.", ex);
            }
        }

        public Booking PutBooking(int BookingId, Booking booking)
        {
            try
            {
                var r = _bookingContext.Hotels.Find(booking.Hotel.HotelId);
                booking.Hotel = r;
                _bookingContext.Entry(booking).State = EntityState.Modified;
                _bookingContext.SaveChanges();
                return booking;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update booking.", ex);
            }
        }
    }
}
