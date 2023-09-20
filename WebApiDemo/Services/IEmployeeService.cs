using WebApiDemo.Entities;

namespace WebApiDemo.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetEmployees();

        Employee GetEmployeeById(int id);

        int AddEmployee(Employee emp);

        int UpdateEmployee(Employee emp);

        int DeleteEmployee(int id);
    }
}
