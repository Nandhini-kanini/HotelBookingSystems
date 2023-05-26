using HotelBookingSystem.Model;
using HotelManagement.Model;

namespace HotelManagement.Repositories
{
    public interface ICustomer
    {
        public IEnumerable<Customer> GetCustomer();
        public Customer GetCustomerById(int CustomerId);
        public Customer PostCustomer(Customer customer);
        public Customer PutCustomer(int CustomerId, Customer customer);
        public Customer DeleteCustomer(int CustomerId);
        public IEnumerable<Hotel> FilterHotels(string location);
        public int GetRoomCount(int RoomId, int HotelId);
        public IEnumerable<Hotel> FilterPriceRange(decimal minPrice, decimal maxPrice);




    }
}
