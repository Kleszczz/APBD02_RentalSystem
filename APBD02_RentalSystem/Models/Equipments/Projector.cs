using APBD02_RentalSystem.Models.Users;

namespace APBD02_RentalSystem.Models.Equipments;

public class Projector(string name, int yearOfPurchase, Employee responsibleEmployee, bool isMobile, int brightness)
    : Equipment(name, yearOfPurchase, responsibleEmployee)
{
    private bool IsMobile {get; set;} = isMobile;
    private int Brightness {get; set;} = brightness; // in lumens
    
    
}