namespace APBD02_RentalSystem.Users;

public abstract class AbstractPerson
{
    private int Id {get; set;}
    private static int NextId {get; set;}
    
    private string name {get; set;}
    private string surname {get; set;}
    
    public AbstractPerson(string name, string surname)
    {
        Id = NextId++;
        this.name = name;
        this.surname = surname;
    }
}