namespace APBD02_RentalSystem.Models.Users;

public enum UserType
{
    Student,
    Employee
}

public abstract class AbstractUser
{
    public int Id { get; }
    private static int NextId {get; set;}
    
    public string Name {get; set;}
    public string Surname {get; set;}
    
    public int MaxRentals {get;}
    public int currentRentals { get; set; } = 0;
    

    protected AbstractUser(string name, string surname,  int maxRentals)
    {
        Id = NextId++;
        this.Name = name;
        this.Surname = surname;
        MaxRentals = maxRentals;
    }
    
    public override string ToString()
    {
        return ($"Id: {Id}, Name: {Name}, Surname: {Surname}");
    }
}