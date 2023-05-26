

using System.ComponentModel.DataAnnotations;

namespace HotelBookingSystem.Model
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }

        public int CustomerPhone { get; set; }

        public Hotel? Hotel { get; set; }


    }
}
