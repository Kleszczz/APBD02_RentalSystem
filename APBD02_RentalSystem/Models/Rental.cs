using APBD02_RentalSystem.Models.Equipments;
using APBD02_RentalSystem.Models.Users;

namespace APBD02_RentalSystem.Models;

public class Rental(DateTime rentalExpectedEndDateAndTime, AbstractUser rentalUser, Equipment rentalEquipment)
{
    private DateTime RentalStartDateAndTime { get; set; } = DateTime.Now; //init at creation
    private DateTime RentalExpectedEndDateAndTime { get; set; } = rentalExpectedEndDateAndTime;
    private DateTime RentalActualEndDateAndTime { get; set; }

    private TimeSpan GetRentalDuration => RentalActualEndDateAndTime - RentalStartDateAndTime;
    private bool IsRentalOverdue => RentalActualEndDateAndTime > RentalExpectedEndDateAndTime;

    private double RentalFee { get; set; }
    private double OverdueFee { get; set; }
    
    private AbstractUser RentalUser { get; set; } = rentalUser;
    private Equipment RentalEquipment { get; set; } = rentalEquipment;
}