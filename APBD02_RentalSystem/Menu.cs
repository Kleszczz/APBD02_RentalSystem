namespace APBD02_RentalSystem;

/*
 Aplikacja powinna wspierać co najmniej następujące operacje: 
1. Dodanie nowego użytkownika do systemu. - metoda
2. Dodanie nowego sprzętu danego typu. 
3. Wyświetlenie listy całego sprzętu z aktualnym statusem. 
4. Wyświetlenie wyłącznie sprzętu dostępnego do wypożyczenia. 
5. Wypożyczenie sprzętu użytkownikowi. 
6. Zwrot sprzętu wraz z przeliczeniem ewentualnej kary za opóźnienie. 
7. Oznaczenie sprzętu jako niedostępnego, np. z powodu uszkodzenia lub serwisu. 
8. Wyświetlenie aktywnych wypożyczeń danego użytkownika. 
9. Wyświetlenie listy przeterminowanych wypożyczeń. 
10. Wygenerowanie krótkiego raportu podsumowującego stan wypożyczalni. 
 */

public class Menu
{

    public void AddNewUser()
    {
        Console.WriteLine("Pick user type:\n 1 - Student \n 2 - Employeee");
        string userType = Console.ReadLine();
        
        Console.WriteLine("Name:");
        string name = Console.ReadLine();
        
        Console.WriteLine("Surname:");
        string surname = Console.ReadLine();

        if (name is null || surname is null)
        {
            Console.WriteLine("Invalid input");
            return;
        }

        if (userType == "1")
        {
            //users.Add(new Student(name, surname));
        }
        else if (userType == "2")
        {
            //users.Add(new Employee(name, surname));
        }
        else
        {
            Console.WriteLine("Invalid input");
            return;
        }
        Console.WriteLine("User added");
    }
    
    
}