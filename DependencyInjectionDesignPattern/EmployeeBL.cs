using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDesignPattern
{
    public class EmployeeBL
    {
        public EmployeeBL()
        {
                
        }
        //For Constructor Dependency Injection
        public EmployeeBL(IEmployeeDAL _employeeDAL)
        {
            employeeDAL = _employeeDAL;
        }
        //For Property Dependency Injection
        public IEmployeeDAL EmployeeDataObject
        {
            set
            {
                this.employeeDAL = value;
            }
        }


        public IEmployeeDAL employeeDAL;
        public List<Employee> GetAllEmployees()
        {
            //Creating an Instance of Dependency Class means it is a Tight Coupling
            //employeeDAL = new EmployeeDAL();
            return employeeDAL.SelectAllEmployees();
        }
        
        //For Method Dependency Injection
        public List<Employee> GetAllEmployees(IEmployeeDAL employeeDAL)
        {
            return employeeDAL.SelectAllEmployees();
        }
    }
}

