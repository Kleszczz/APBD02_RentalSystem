using APBD02_RentalSystem.Models;
using APBD02_RentalSystem.Models.Equipments;
using APBD02_RentalSystem.Models.Users;

namespace APBD02_RentalSystem.Services;

public class RentalService
{
    public static List<Rental> _rentals = new List<Rental>();

    public static void RentEquipmentToUser(int userInputUserId, int userInputEquipmentId,
        DateTime rentalExpectedEndDateAndTime)
    {
        AbstractUser rentalUserObject = null;
        foreach (var user in UserService._users)
        {
            if (user.Id == userInputUserId)
            {
                rentalUserObject = user;
                break;
            }
        }

        if (rentalUserObject == null)
        {
            Console.WriteLine("User not found.");
            Console.WriteLine("\nClick enter to go back...");
            Console.ReadKey();
            return;
        }

        if (rentalUserObject.currentRentals >= rentalUserObject.MaxRentals)
        {
            Console.WriteLine("User achieved max rentals limit.");
            Console.WriteLine(rentalUserObject.currentRentals);
            Console.WriteLine(rentalUserObject.MaxRentals);
            Console.WriteLine("\nClick enter to go back...");
            Console.ReadKey();
            return;
        }


        Equipment rentalEquipmentObject = null;
        foreach (var equipment in EquipmentService._equipments)
        {
            if (equipment.Id == userInputEquipmentId)
            {
                rentalEquipmentObject = equipment;
                break;
            }
        }

        if (rentalEquipmentObject == null)
        {
            Console.WriteLine("Equipment not found.");
            Console.WriteLine("\nClick enter to go back...");
            Console.ReadKey();
            return;
        }

        if (!rentalEquipmentObject.IsAvailable)
        {
            Console.WriteLine("Equipment is NOT AVAILABLE.");
            Console.WriteLine("\nClick enter to go back...");
            Console.ReadKey();
            return;
        }

        _rentals.Add(new Rental(rentalExpectedEndDateAndTime, rentalUserObject, rentalEquipmentObject));
        
        rentalEquipmentObject.IsAvailable = false;
        rentalUserObject.currentRentals += 1;
        
        Console.WriteLine($"Equipment {rentalEquipmentObject} rented for {rentalUserObject}.");
        Console.WriteLine("Click enter to go back...");
        Console.ReadKey();
    }
}