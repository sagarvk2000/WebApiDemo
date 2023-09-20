using WebApiDemo.Entities;
using WebApiDemo.Repositories;

namespace WebApiDemo.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmpolyeeRepository repo;

        public EmployeeService(IEmpolyeeRepository repo)
        {
            this.repo=repo;
        }
        public int AddEmployee(Employee emp)
        {
            return repo.AddEmployee(emp);
        }

        public int DeleteEmployee(int id)
        {
            return repo.DeleteEmployee(id);
        }

        public Employee GetEmployeeById(int id)
        {
            return repo.GetEmployeeById(id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return repo.GetEmployees();
        }

        public int UpdateEmployee(Employee emp)
        {
            return repo.UpdateEmployee(emp);
        }
    }
}
