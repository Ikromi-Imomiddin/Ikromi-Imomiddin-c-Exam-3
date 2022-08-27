using Domain.Modles;

namespace Infrastructure.Services;

public class DepartmentService
{
     private List<Department> Departments;

     public DepartmentService()
     {
         Departments = new List<Department>();
     }
     public List<Department> GetDepartments(){
         return Departments;
     }
    public void AddDepartment(Department Department)
     {
        Departments.Add(Department);
     }
    public void UpdateDepartment(Department department, int id)
    {
        var update = Departments.Find(x=>x.Id == id);
        update.Id = department.Id;
        update.Name = department.Name;
        update.Description = department.Description;
    } 
    public Department GetDepartmentById(int id)
    {
       var Department =  Departments.Find(element=> element.Id == id);
       return Department;

    }
    public void Delete(int id)
    {
        var department1 = Departments.Find(x=>x.Id == id);
        Departments.Remove(department1);
    }
    public void Count(int count)
    {
        count=Departments.Count();
    }
   
}

