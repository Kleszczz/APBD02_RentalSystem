using System.Runtime.CompilerServices;

namespace APBD02_RentalSystem.Models.Users;

public class Employee(string name, string surname)
    : AbstractUser(name, surname)
{
    
}