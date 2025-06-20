
namespace EmployeeMS.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Bishwa", Email = "abc@gmail.com", Department = "IT" },
                new Employee() { Id = 2, Name = "John", Email = "xyz@gmail.com", Department = "HR" },
                new Employee() { Id = 3, Name = "Jane", Email = "yes@gmail.com", Department = "Finance" }
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
           return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}
