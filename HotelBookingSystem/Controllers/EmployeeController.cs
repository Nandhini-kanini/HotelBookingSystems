using HotelManagement.Model;
using HotelManagement.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployee emp;
        public EmployeesController(IEmployee emp)
        {
            this.emp = emp;
        }
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return emp.GetEmployees();
        }

        [HttpGet("{id}")]
        public Employee GetById(int id)
        {
            return emp.GetEmployeesById(id);
        }

        [HttpPost]
        public Employee PostEmployee(Employee employee)
        {
            return emp.PostEmployee(employee);
        }
        [HttpPut("{id}")]
        public Employee PutEmployee(int id, Employee employee)
        {
            return emp.PutEmployee(id, employee);
        }
        [HttpDelete("{id}")]
        public Employee DeleteEmployee(int id)
        {
            return emp.DeleteEmployee(id);
        }



    }
}
