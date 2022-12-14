namespace Domain.Modles;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string Adress { get; set; }
    public string Phone { get; set; }
    public Department Department { get; set; }
    public List<Role> Roles { get; set; }
    public List<Experience> Experiences   { get; set; }

    public void GetInfo()
    {
        System.Console.WriteLine($"{FirstName} {LastName}");
        System.Console.WriteLine($"Departmetnt: {Department}");
        System.Console.WriteLine($"Experiences: {Experiences}");
        System.Console.WriteLine($"Roles: {Roles}");
        System.Console.WriteLine("    ");
    }
}

