using HotelManagement.Model;

namespace HotelManagement.Repositories
{
    public interface IEmployee
    {
        public IEnumerable<Employee> GetEmployees();
        public Employee GetEmployeesById(int EmployeeId);
        public Employee PostEmployee(Employee employee);
        public Employee PutEmployee(int EmployeeId, Employee employee);
        public Employee DeleteEmployee(int EmployeeId);


    }
}
