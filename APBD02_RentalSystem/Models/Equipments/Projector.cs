using APBD02_RentalSystem.Users;

namespace APBD02_RentalSystem.Equipments;

public class Projector(string name, int yearOfPurchase, Employee responsibleEmployee, bool isMobile, int brightness)
    : Equipment(name, yearOfPurchase, responsibleEmployee)
{
    private bool isMobile = isMobile;
    private int brightness = brightness; // in lumens
    
    
}