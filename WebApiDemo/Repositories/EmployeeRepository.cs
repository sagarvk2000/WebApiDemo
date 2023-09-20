using WebApiDemo.Entities;

namespace WebApiDemo.Repositories
{
    public class EmployeeRepository:IEmpolyeeRepository
    {
        private readonly ApplicationDbContext context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            this.context=context;   
        }

        public int AddEmployee(Employee emp)
        {
            int res = 0;
            context.Employees.Add(emp);
            res = context.SaveChanges();
            return res;
        }

        public int DeleteEmployee(int id)
        {
            int res = 0;
            var emp = context.Employees.Where(x => x.Id == id).FirstOrDefault();
            if (emp != null)
            {
                emp.IsActive = 0;
                res = context.SaveChanges();
            }
            return res;
        }

        public Employee GetEmployeeById(int id)
        {
            int result = 0;
            var emp = context.Employees.Where(x => x.Id == id).FirstOrDefault();
            return emp;
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return context.Employees.Where(x => x.IsActive == 1).ToList();
        }

        public int UpdateEmployee(Employee emp)
        {
            int result = 0;
            var b = context.Employees.Where(x => x.Id == emp.Id).FirstOrDefault();
            if (b != null)
            {
                b.Name = emp.Name;
                b.Department = emp.Department;
                b.Salary = emp.Salary;
                b.IsActive = 1;
                result = context.SaveChanges();
            }
            return result;
        }
    }
}
