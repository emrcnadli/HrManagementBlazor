using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Services
{
    public class EmployeeService
    {
        private List<Employee> _employees = new List<Employee>();

        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            var existingEmployee = _employees.FirstOrDefault(e => e.EmployeeID == employee.EmployeeID);
            if (existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                existingEmployee.Position = employee.Position;
                existingEmployee.Salary = employee.Salary;
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            var employee = _employees.FirstOrDefault(e => e.EmployeeID == employeeId);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
        }
    }
}
