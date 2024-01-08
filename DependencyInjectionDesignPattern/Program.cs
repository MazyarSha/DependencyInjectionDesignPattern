// See https://aka.ms/new-console-template for more information
using DependencyInjectionDesignPattern;

Console.WriteLine("Hello, World!");

#region Constructor Dependency Injection
EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());
#endregion


#region Property Dependency Injection
EmployeeBL employeeBL1 = new EmployeeBL();
employeeBL1.employeeDAL = new  EmployeeDAL();
#endregion

List<Employee> ListEmployee = employeeBL.GetAllEmployees();
foreach (Employee emp in ListEmployee)
{
    Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}, Department = {emp.Department}");
}

#region Method Dependency Injection
List<Employee> ListEmployee1 = employeeBL1.GetAllEmployees(new EmployeeDAL());

#endregion

Console.ReadKey();
