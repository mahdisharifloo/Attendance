using Attendance.Entity;

namespace Attendance.Business
{
    public class EmployeeBusiness
    {
        private List<Employee> employees = new List<Employee>();

        public EmployeeBusiness()
        {
            employees.Add(new Employee() { Age = 2 , Id = 1 , FirstName = "reza"});
            employees.Add(new Employee() { Age = 2 , Id = 1 , FirstName = "mehdi"});

        }

        public List<Employee> Employees()
        {
            return employees;
        }
    }
}
