using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDesignPattern
{
    public class EmployeeDAL : IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>
            {
                //Get the Employees from the Database
                //for now we are hard coded the employees
                new Employee() { ID = 1, Name = "Pranaya", Department = "IT" },
                new Employee() { ID = 2, Name = "Kumar", Department = "HR" },
                new Employee() { ID = 3, Name = "Rout", Department = "Payroll" }
            };
            return ListEmployees;
        }
    }
}
