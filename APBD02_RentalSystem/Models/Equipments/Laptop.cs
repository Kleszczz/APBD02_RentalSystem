using APBD02_RentalSystem.Models.Users;

namespace APBD02_RentalSystem.Models.Equipments;

public class Laptop(string name, int yearOfPurchase, Employee responsibleEmployee, int screenHz, bool? hasTouchPad)
    : Equipment(name, yearOfPurchase, responsibleEmployee)
{
    private int ScreenHz {get; set;} = screenHz;
    private bool? HaveTouchPad {get; set;} = hasTouchPad;
    
    
}