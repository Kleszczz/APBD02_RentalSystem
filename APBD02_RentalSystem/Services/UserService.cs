using APBD02_RentalSystem.Models.Users;

namespace APBD02_RentalSystem.Services;

public class UserService
{
    private static List<AbstractUser> _users = new List<AbstractUser>();

    public static void AddNewUser(UserType userType, string name, string surname)
    {
        AbstractUser newUser = null;
        
        switch (userType)
        {
            case UserType.Student:
                newUser = new Student(name, surname);
                break;
            case UserType.Employee:
                newUser = new Employee(name, surname);
                break;
            default:
                throw new ArgumentException("Unknown user type");
        }

        if (newUser != null)
        {
            _users.Add(newUser);
        }
    }
}