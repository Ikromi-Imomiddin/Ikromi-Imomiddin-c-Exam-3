
using Domain.Modles;

namespace Infrastructure.Services;

public class ExperienceService
{
    private List<Experience> Experiences;

     public ExperienceService()
     {
         Experiences = new List<Experience>();
     }
     public List<Experience> GetExperiences(){
         return Experiences;
     }
    public void AddExperience(Experience Experience)
     {
        Experiences.Add(Experience);
     }
    public void UpdateExperience(Experience Experience, int id)
    {
        var update = Experiences.Find(x=>x.Id == id);
        update.Id = Experience.Id;
        update.Name = Experience.Name;
        update.Description = Experience.Description;
        update.Company = Experience.Company;
        update.EmployeeId = Experience.EmployeeId;
    } 
    public Experience GetExperienceById(int id)
    {
       var Experience =  Experiences.Find(element=> element.Id == id);
       return Experience;

    }
    public void Delete(int id)
    {
        var Experience1 = Experiences.Find(x=>x.Id == id);
        Experiences.Remove(Experience1);
    }
    public void Count(int count)
    {
        count=Experiences.Count();
    }
}
