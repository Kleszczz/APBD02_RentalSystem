using APBD02_RentalSystem.Models.Equipments;
using APBD02_RentalSystem.Models.Users;

namespace APBD02_RentalSystem.Services;

public class EquipmentService
{
    private static List<Equipment> _equipments = new List<Equipment>() {};
    
    public static void AddNewCamera(string name, int yearOfPurchase, Employee responsibleEmployee, int maxFps, string lenseType)
    {
        Camera newCamera = new Camera(name, yearOfPurchase, responsibleEmployee, maxFps, lenseType);
        _equipments.Add(newCamera);
    }
    
    public static void AddNewLaptop(string name, int yearOfPurchase, Employee responsibleEmployee, int screenHz, bool? hasTouchPad)
    {
        Laptop newLaptop = new Laptop(name, yearOfPurchase, responsibleEmployee, screenHz, hasTouchPad);
        _equipments.Add(newLaptop);
    }
    
    public static void AddNewProjector(string name, int yearOfPurchase, Employee responsibleEmployee, bool? isMobile, int brightness)
    {
        Projector newProjector = new Projector(name, yearOfPurchase, responsibleEmployee, isMobile, brightness);
        _equipments.Add(newProjector);
    }
}