using System.Collections.Generic;
using WebAPIDemo.Models;
using WebAPIDemo.Repository;

namespace WebAPIDemo.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository repository;

        public EmployeeService(IEmployeeRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return repository.GetAll();
        }

        public Employee GetEmployee(int id)
        {
            return repository.GetById(id);
        }

        public void CreateEmployee(Employee employee)
        {
            repository.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            repository.Update(employee);
        }

        public void DeleteEmployee(int id)
        {
            repository.Delete(id);
        }
    }
}
