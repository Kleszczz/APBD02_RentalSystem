using System.Runtime.CompilerServices;

namespace APBD02_RentalSystem.Models.Users;

public class Employee : AbstractUser
{
    public Employee(string name, string surname) : base(name, surname, 5)
    {
    }
}