using APBD02_RentalSystem.Users;

namespace APBD02_RentalSystem.Equipments;

public class Camera(string name, int yearOfPurchase, Employee responsibleEmployee, int maxFps, Camera.LenseTypeEnum lenseType
    ) : Equipment(name, yearOfPurchase, responsibleEmployee)
{
    public enum LenseTypeEnum
    {
        FishEye,
        WideAngle,
        ZoomLense
    }
    
    private int MaxFps {get; set;} = maxFps;
    private LenseTypeEnum LenseType {get; set;} = lenseType;
}