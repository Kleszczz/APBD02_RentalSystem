using APBD02_RentalSystem.Models.Users;

namespace APBD02_RentalSystem.Models.Equipments;

public class Camera(string name, int yearOfPurchase, Employee responsibleEmployee, int maxFps, string? lenseType
    ) : Equipment(name, yearOfPurchase, responsibleEmployee)
{
    
    private int MaxFps {get; set;} = maxFps;
    private string? LenseType {get; set;} = lenseType;
}