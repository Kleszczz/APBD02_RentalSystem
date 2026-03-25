using APBD02_RentalSystem.Models.Users;

namespace APBD02_RentalSystem.Models.Equipments;

/*
- Każdy egzemplarz sprzętu powinien mieć unikalny identyfikator generowany przez system.
- Każdy sprzęt powinien przechowywać nazwę, status dostępności oraz podstawowe dane wspólne.
- Każdy typ sprzętu powinien posiadać przynajmniej 2 własne pola specyficzne.
 */

public enum EquipmentType
{
    Camera,
    Laptop,
    Projector
}

public abstract class Equipment
{
    private int Id {get; set;}
    private static int NextId {get; set;}
    
    private string Name {get; set;}
    private bool IsAvailable {get; set;}
    
    private int YearOfPurchase {get; set;}
    private Employee ResponsibleEmployee {get; set;}
    
    //TODO: Dodaj jeszcze wiecej pol wspolnych

    protected Equipment(string name, int yearOfPurchase, Employee responsibleEmployee)
    {
        this.Id = NextId++;
        this.Name = name;
        this.YearOfPurchase = yearOfPurchase;
        this.ResponsibleEmployee = responsibleEmployee;
        this.IsAvailable = true;
    }
}