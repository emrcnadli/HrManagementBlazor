using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Services
{
    public class EmployeeService
    {
        //Employee model in a List structure.
        private List<Employee> _employees = new List<Employee>();

        public List<Employee> GetEmployees()
        {
            //returns List structured Employees
            return _employees;
        }

        public void AddEmployee(Employee employee)
        {
            //Add Employee in List
            _employees.Add(employee);
        }

        public void UpdateEmployee(Employee employee, Employee existingEmployee)
        {
            //Look for given employee is it exist or not.
            var isexistEmployee = _employees.FirstOrDefault(e => e.EmployeeID == existingEmployee.EmployeeID);
            if (isexistEmployee != null)
            {
                //if exist assign collected informations about employee to a variable.
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
