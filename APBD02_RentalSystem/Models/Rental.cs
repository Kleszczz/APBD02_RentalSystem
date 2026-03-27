using APBD02_RentalSystem.Models.Equipments;
using APBD02_RentalSystem.Models.Users;

namespace APBD02_RentalSystem.Models;

public class Rental()
{
    private static int _nextId = 1;
    public int Id { get; private set; }
    
    public AbstractUser RentalUser { get; set; }
    public Equipment RentalEquipment { get; set; }
    
    public DateTime RentalStartDateAndTime { get;} = DateTime.Now; //init at creation
    public DateTime RentalExpectedEndDateAndTime { get;}
    public DateTime? RentalActualEndDateAndTime { get; set; }
    
    public double RentalFee { get; set; }
    public double OverdueFee { get; set; }

    public Rental(DateTime rentalExpectedEndDateAndTime, AbstractUser rentalUser, Equipment rentalEquipment) : this()
    {
        Id = _nextId++;
        RentalStartDateAndTime = DateTime.Now;
        RentalExpectedEndDateAndTime = rentalExpectedEndDateAndTime;
        RentalUser = rentalUser;
        RentalEquipment = rentalEquipment;
    }
    
    public TimeSpan? GetRentalDuration => RentalActualEndDateAndTime - RentalStartDateAndTime;
    public bool IsRentalOverdue => RentalActualEndDateAndTime > RentalExpectedEndDateAndTime;
    
    public override string ToString()
    {
        return $"Rental ID: {Id} | User: {RentalUser} | Equipment: {RentalEquipment} | Due: {RentalExpectedEndDateAndTime}";
    }
}