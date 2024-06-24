using EmployeeManagementSystem.Client.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Client.Services
{
    public class EmployeeService
    {
        private readonly HttpClient httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await httpClient.GetFromJsonAsync<List<Employee>>("api/employees");
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await httpClient.GetFromJsonAsync<Employee>($"api/employees/{id}");
        }

        public async Task AddEmployeeAsync(Employee employee)
        {
            await httpClient.PostAsJsonAsync("api/employees", employee);
        }

        public async Task UpdateEmployeeAsync(Employee employee)
        {
            await httpClient.PutAsJsonAsync($"api/employees/{employee.EmployeeID}", employee);
        }

        public async Task DeleteEmployeeAsync(int id)
        {
            await httpClient.DeleteAsync($"api/employees/{id}");
        }
    }
}
