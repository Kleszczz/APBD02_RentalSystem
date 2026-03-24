namespace APBD02_RentalSystem;

public class Rental
{
    private DateTime rentalStartDateAndTime { get; set; }
    private DateTime rentalEndDateAndTime { get; set; }
    
    private double rentalFee { get; set; }
    private double overdueFee { get; set; }

    public Rental()
    {
        
    }
}