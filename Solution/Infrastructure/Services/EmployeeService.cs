using Domain.Modles;

namespace Infrastructure.Services;

    public class EmployeeService
{
     private List<Employee> Employees;

     public EmployeeService()
     {
         Employees = new List<Employee>();
     }
     public List<Employee> GetEmployees(){
         return Employees;
     }
    public void AddEmployee(Employee Employee)
     {
        Employees.Add(Employee);
     }
    public void UpdateEmployee(Employee Employee, int id)
    {
        var update = Employees.Find(x=>x.Id == id);
        update.Id = Employee.Id;
        update.Department = Employee.Department;
        update.LastName = Employee.LastName;
        update.FirstName = Employee.FirstName;
        update.Phone = Employee.Phone;
        update.Roles = Employee.Roles;
        update.Experiences = Employee.Experiences;
        update.Adress = Employee.Adress;
        update.BirthDate = Employee.BirthDate;
    } 
    public Employee GetEmployeeById(int id)
    {
       var Employee =  Employees.Find(element=> element.Id == id);
       return Employee;

    }
    public void Delete(int id)
    {
        var Employee1 = Employees.Find(x=>x.Id == id);
        Employees.Remove(Employee1);
    }
    public void Count(int count)
    {
        count=Employees.Count();
    }
    
   
}