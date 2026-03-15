namespace APBD02_RentalSystem.Equipments;

/*
- Każdy egzemplarz sprzętu powinien mieć unikalny identyfikator generowany przez system.
- Każdy sprzęt powinien przechowywać nazwę, status dostępności oraz podstawowe dane wspólne.
- Każdy typ sprzętu powinien posiadać przynajmniej 2 własne pola specyficzne.
 */

public abstract class Equipment
{
    private int Id {get; set;}
    private static int NextId {get; set;}
    private string Name {get; set;}
    private Boolean isAvailable {get; set;}
    
    //TODO: Dodaj jeszcze wiecej pol wspolnych

    public Equipment()
    {
        Id = NextId++;
    }
}