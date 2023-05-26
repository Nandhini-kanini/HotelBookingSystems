﻿using BigBang.Models;

namespace BigBang.Repositories
{
    public interface IBooking
    {
        public IEnumerable<Booking> GetBooking();
        public Booking GetBookingById(int BookingId);
        public Booking PostBooking(Booking booking);
        public Booking PutBooking(int BookingId, Booking booking);
        
    }
}