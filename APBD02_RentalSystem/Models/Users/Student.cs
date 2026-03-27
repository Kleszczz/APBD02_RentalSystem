namespace APBD02_RentalSystem.Models.Users;

public class Student : AbstractUser
{
    public Student(string name, string surname) : base(name, surname, 2)
    {
    }
}