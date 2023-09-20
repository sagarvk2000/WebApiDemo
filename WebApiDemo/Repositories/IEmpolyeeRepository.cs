using WebApiDemo.Entities;

namespace WebApiDemo.Repositories
{
    public interface IEmpolyeeRepository
    {
        IEnumerable<Employee> GetEmployees();

        Employee GetEmployeeById(int id);

        int AddEmployee(Employee emp);

        int UpdateEmployee(Employee emp);

        int DeleteEmployee(int id);
    }
}

