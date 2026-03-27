using APBD02_RentalSystem.Models.Equipments;
using APBD02_RentalSystem.Models.Users;

namespace APBD02_RentalSystem.Services;

public class EquipmentService
{
    public static List<Equipment> _equipments = new List<Equipment>();

    public static void AddNewCamera(string name, int yearOfPurchase, Employee responsibleEmployee, int maxFps,
        string lenseType)
    {
        Camera newCamera = new Camera(name, yearOfPurchase, responsibleEmployee, maxFps, lenseType);
        _equipments.Add(newCamera);
    }

    public static void AddNewLaptop(string name, int yearOfPurchase, Employee responsibleEmployee, int screenHz,
        bool? hasTouchPad)
    {
        Laptop newLaptop = new Laptop(name, yearOfPurchase, responsibleEmployee, screenHz, hasTouchPad);
        _equipments.Add(newLaptop);
    }

    public static void AddNewProjector(string name, int yearOfPurchase, Employee responsibleEmployee, bool? isMobile,
        int brightness)
    {
        Projector newProjector = new Projector(name, yearOfPurchase, responsibleEmployee, isMobile, brightness);
        _equipments.Add(newProjector);
    }

    public static void DisplayAllEquipment()
    {
        Console.Clear();
        Console.WriteLine("=== EQUIPMENT REGISTRY ===");
        Console.WriteLine($"Equipment count: {_equipments.Count}");
        foreach (var equipment in _equipments)
        {
            Console.WriteLine($"1: {equipment} - {equipment.IsAvailable}");
        }

        Console.WriteLine("Naciśnij dowolny klawisz, aby wrócić...");
        Console.ReadKey();
    }

    public static void DisplayAllAvailableEquipment()
    {
        Console.Clear();
        Console.WriteLine("=== AVAILABLE EQUIPMENT REGISTRY ===");
        Console.WriteLine($"Equipment count: {_equipments.Count}");
        foreach (var equipment in _equipments)
        {
            if (equipment.IsAvailable )
            {
                Console.WriteLine($"EQ: {equipment} - {equipment.IsAvailable}");
            }
        }

        Console.WriteLine("Click enter to continue...");
        Console.ReadKey();
    }

    public static void MarkEquipmentAsUnavailable(int userInputEquipmentId)
    {
        foreach (var equipment in _equipments)
        {
            if (equipment.Id == userInputEquipmentId)
            {
                equipment.IsOutOfService = !equipment.IsOutOfService;
                Console.WriteLine($"Equipment has been marked as: IsOutOfService: {equipment.IsOutOfService}");
                break;
            }
        }
        Console.WriteLine("Click enter to continue...");
        Console.ReadKey();
    }
}