namespace APBD02_RentalSystem.Models.Users;

public abstract class AbstractUser
{
    private int Id {get; set;}
    private static int NextId {get; set;}
    
    private string Name {get; set;}
    private string Surname {get; set;}

    protected AbstractUser(string name, string surname)
    {
        Id = NextId++;
        this.Name = name;
        this.Surname = surname;
    }
}