
using EmployeeApp.App.Services.Interfaces;
using EmployeeApp.Core.Models;
using EmployeeApp.Data.Repositories;

namespace EmployeeApp.App.Services.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeRepository _employeeRepository = new EmployeeRepository();
        public void Create()
        {
            Employee employee = new Employee();
            Console.WriteLine("Add Name");
            employee.Name = Console.ReadLine();
            Console.WriteLine("Add Surname");
            employee.Surname = Console.ReadLine();
            Console.WriteLine("Ädd Salary");
            employee.Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Add Position");
            employee.Position = Console.ReadLine();
            _employeeRepository.Create(employee);
        }

        public void Delete()
        {
            Console.WriteLine("Enter ID");
            int.TryParse(Console.ReadLine(), out int id);
            Employee employee = _employeeRepository.Get(id);

            if (employee == null)
            {
                Console.WriteLine("Employee not found");

            }
            else
            {
                _employeeRepository.Delete(employee);
                Console.WriteLine("Employee deleted");
            }
        }

        public void Get()
        {
            Console.WriteLine("Enter ID");
            int.TryParse(Console.ReadLine(), out int id);
            Employee employee = _employeeRepository.Get(id);

            if (employee == null)
            {
                Console.WriteLine("Employee not found");

            }
            else
            {
                Console.WriteLine(employee);
            }

        }

        public void GetAll()
        {
            List<Employee> employees = _employeeRepository.GetAll();
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }
        public void Update()
        {
            Console.WriteLine("Enter ID");
            int.TryParse(Console.ReadLine(), out int id);
            Employee employee = _employeeRepository.Get(id);

            if (employee == null)
            {
                Console.WriteLine("Employee not found");

            }
            else
            {
                Console.WriteLine("Add Name");
                employee.Name = Console.ReadLine();

            }
        }
    }

 }

