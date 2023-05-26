using System.ComponentModel.DataAnnotations;

namespace HotelBookingSystem.Model
{
    public class Room
    {
        internal bool IsAvailable;

        [Key]
        public int RoomId { get; set; }
        public int HotelId { get; set; }
        public int RoomCount { get; set; }
        public string ?RoomNumber { get; set; }
        public string ?RoomType { get; set; }
        public int ?Capacity { get; set; }
        public int? Availability { get; set; }
        public Hotel ?Hotel { get; set; }
        
    }
}
