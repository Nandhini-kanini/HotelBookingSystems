
using Microsoft.AspNetCore.Mvc;
using HotelManagement.Repositories;
using HotelBookingSystem.Model;
using Microsoft.AspNetCore.Authorization;

namespace HotelManagement.Controllers
{

   // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        private readonly ICustomer cus;
        public CustomersController(ICustomer cus)
        {
            this.cus = cus;
        }
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return cus.GetCustomer();
        }

        [HttpGet("{CustomerId}")]
        public Customer GetById(int CustomerId)
        {
            return cus.GetCustomerById(CustomerId);
        }

        [HttpPost]
        public Customer PostCustomer(Customer customer)
        {
            return cus.PostCustomer(customer);
        }
        [HttpPut("{CustomerId}")]
        public Customer PutCustomer(int CustomerId, Customer customer)
        {
            return cus.PutCustomer(CustomerId, customer);
        }
        [HttpDelete("{CustomerId}")]
        public Customer DeleteCustomer(int CustomerId)
        {
            return cus.DeleteCustomer(CustomerId);
        }
        [HttpGet("filter")]
        public IEnumerable<Hotel> FilterHotels(string location)
        {
            return cus.FilterHotels(location);
        }


        [HttpGet("roomcount")]
        public int GetRoomCount(int RoomId, int HotelId)
        {

            return cus.GetRoomCount(RoomId, HotelId);


        }
        [HttpGet("price-range")]
        public IEnumerable<Hotel> FilterPriceRange(decimal minPrice, decimal maxPrice)
        {
            return cus.FilterPriceRange(minPrice, maxPrice);
        }


    }
}
