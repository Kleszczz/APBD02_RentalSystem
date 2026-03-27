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

    public static void ReturnEquipment(int userInputEquipmentId)
    {
        Rental rentalObject = null;
        foreach (var rental in _rentals)
        {
            if (rental.RentalEquipment.Id == userInputEquipmentId && rental.RentalActualEndDateAndTime == null)
            {
                rentalObject = rental;
                break;
            }
        }

        if (rentalObject == null)
        {
            Console.WriteLine("Rental not found.");
            Console.WriteLine("\nClick enter to go back...");
            Console.ReadKey();
            return;
        }

        rentalObject.RentalActualEndDateAndTime = DateTime.Now;
        rentalObject.RentalEquipment.IsAvailable = true;
        rentalObject.RentalUser.currentRentals -= 1;

        if (rentalObject.IsRentalOverdue)
        {
            int overdueDays = (int)Math.Ceiling(rentalObject.GetRentalOverdueDuration.Value.TotalDays);

            double overduePenalty = Rental.OverdueFee * overdueDays;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Overdue Penalty: {overduePenalty}PLN - {overdueDays} days");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Returned on time, no penalty.");
        }

        Console.WriteLine($"Returned {rentalObject.RentalEquipment} from {rentalObject.RentalUser}.");
        Console.WriteLine("\nClick enter to go back...");
        Console.ReadKey();
    }

    public static void DisplayAllActiveRentals()
    {
        foreach (var rental in _rentals)
        {
            if (rental.RentalActualEndDateAndTime == null)
            {
                Console.WriteLine(rental.RentalEquipment);
            }
        }

        Console.WriteLine("\nClick enter to go back...");
        Console.ReadKey();
    }
    
    
    public static void DisplayAllActiveRentalsForUser(int userId)
    {
        foreach (var rental in _rentals)
        {
            if (rental.RentalUser.Id == userId && rental.RentalActualEndDateAndTime == null)
            {
                Console.WriteLine(rental.RentalEquipment);
            }
        }

        Console.WriteLine("\nClick enter to go back...");
        Console.ReadKey();
    }
}