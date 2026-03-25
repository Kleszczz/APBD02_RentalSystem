using APBD02_RentalSystem.Equipments;
using APBD02_RentalSystem.Users;

namespace APBD02_RentalSystem;

public class Rental(DateTime rentalExpctedEndDateAndTime, AbstractPerson rentalPerson, Equipment rentalEquipment)
{
    private DateTime rentalStartDateAndTime { get; set; } = DateTime.Now; //init at creation
    private DateTime rentalExpectedEndDateAndTime { get; set; } = rentalExpctedEndDateAndTime;
    private DateTime rentalActualEndDateAndTime { get; set; }

    private TimeSpan getRentalDuration => rentalActualEndDateAndTime - rentalStartDateAndTime;
    private bool isRentalOverdue => rentalActualEndDateAndTime > rentalExpectedEndDateAndTime;

    private double rentalFee { get; set; }
    private double overdueFee { get; set; }
    
    private AbstractPerson rentalPerson { get; set; } = rentalPerson;
    private Equipment rentalEquipment { get; set; } = rentalEquipment;
}