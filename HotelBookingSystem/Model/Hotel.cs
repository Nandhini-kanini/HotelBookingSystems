using System.ComponentModel.DataAnnotations;

namespace HotelBookingSystem.Model
{
    public class Hotel
    {
        [Key]
        public int HotelId { get; set; }
        public string ?HotelName { get; set; }
        public string ?HotelAddress { get; set; }
        public string ?HotelCity { get; set; }
        public string ?HotelCountry { get; set; }

        public int Price { get; set; }
        public string? Amenities { get; set; }

        public ICollection<Room>? Rooms { get; set; }

        public ICollection<Customer>? Customers { get; set; }
    }
}
