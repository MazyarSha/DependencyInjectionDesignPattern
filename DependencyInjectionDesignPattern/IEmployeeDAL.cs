using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDesignPattern
{
    public interface IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees();
    }
}
