using APBD02_RentalSystem.Users;

namespace APBD02_RentalSystem.Equipments;

public class Laptop(string name, int yearOfPurchase, Employee responsibleEmployee, int screenHz, bool hasTouchPad)
    : Equipment(name, yearOfPurchase, responsibleEmployee)
{
    private int screenHz {get; set;} = screenHz;
    private bool hasTouchPad {get; set;} = hasTouchPad;
    
    
}