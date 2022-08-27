using Domain.Modles;

namespace Infrastructure.Services;

public class RoleService
{
     private List<Role> Roles;

     public RoleService()
     {
         Roles = new List<Role>();
     }
     public List<Role> GetRoles(){
         return Roles;
     }
    public void AddRole(Role Role)
     {
        Roles.Add(Role);
     }
    public void UpdateRole(Role Role, int id)
    {
        var update = Roles.Find(x=>x.Id == id);
        update.Id = Role.Id;
        update.Name = Role.Name;
        update.Description = Role.Description;
        update.EmployeeId = Role.EmployeeId;
    } 
    public Role GetRoleById(int id)
    {
       var Role =  Roles.Find(element=> element.Id == id);
       return Role;

    }
    public void Delete(int id)
    {
        var Role1 = Roles.Find(x=>x.Id == id);
        Roles.Remove(Role1);
    }
    public void Count(int count)
    {
        count=Roles.Count();
    }
}
