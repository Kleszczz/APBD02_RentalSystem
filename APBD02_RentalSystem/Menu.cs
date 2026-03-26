using APBD02_RentalSystem.Models.Users;
using APBD02_RentalSystem.Services;

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

public abstract class Menu
{
    public static void RunMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== MAIN MENU ===");
            Console.WriteLine("1. Register new user");
            Console.WriteLine("2. Add new equipment");
            Console.WriteLine("3. Rent equipment");
            Console.WriteLine("0. Exit");
            Console.WriteLine("===================");
            Console.Write("Choose an option: ");

            var choice = GetValidInput();

            switch (choice)
            {
                case "1":
                    RegisterNewUser();
                    break;
                case "2":
                    RegisterNewEquipment();
                    break;
                case "3":
                    // RentEquipment();
                    break;
                case "0":
                    Environment.Exit(0); //Kills the program
                    break;
                default:
                    Console.WriteLine("Unknown option, click ENTER to continue.");
                    Console.ReadLine();
                    break;
            }
        }
    }


    public static void RegisterNewUser()
    {
        Console.Clear();
        Console.WriteLine("=== USER REGISTRATION ===");

        Console.WriteLine("Pick user type to create (type number)");
        Console.WriteLine("'1' - Student \n '2' - Employee \n '0' - Exit");
        Console.Write("Input user type: ");
        var userInput = GetValidInput();

        if (userInput == "0") //exit to previous menu step
        {
            return;
        }

        Console.WriteLine("Input name and surname");
        Console.Write("Name: ");
        var name = GetValidInput();
        Console.Write("Surname: ");
        var surname = GetValidInput();

        try
        {
            switch (userInput)
            {
                case "1": //Student
                    UserService.AddNewUser(UserType.Student, name, surname);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("STUDENT CREATED");
                    Console.ResetColor();
                    break;
                case "2": //Employee
                    UserService.AddNewUser(UserType.Employee, name, surname);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("EMPLOYEE CREATED");
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine("Wrong user type. Try again.");
                    break;
            }
        }
        catch (ArgumentException ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Service error: {ex.Message}");
            Console.ResetColor();
        }


        Console.WriteLine("Naciśnij dowolny klawisz, aby wrócić...");
        Console.ReadKey();
    }


    public static void RegisterNewEquipment()
    {
        Console.Clear();
        Console.WriteLine("=== EQUIPMENT REGISTRATION ===");

        Console.WriteLine("Pick equipment type to create (type number)");
        Console.WriteLine("'1' - Camera \n '2' - Laptop \n '3' - Projector \n '0' - Exit");
        Console.Write("Input user type: ");
        var userInput = GetValidInput();

        if (userInput == "0") //exit to previous menu step
        {
            return;
        }

        Console.WriteLine("Input data:");
        Console.Write("Name: ");
        var name = GetValidInput();
        Console.Write("yearOfPurchase: ");
        int yearOfPurchase = Convert.ToInt32(GetValidInput());

        Employee responsibleEmployee = new Employee("adam", "kowalski");
        //wypisanie employee i ich indeksow
        //zapytanie o numer indeksu pracownika
        //przypisanie do pracownika urzwedzenia jako obpiekun.


        switch (userInput)
        {
            case "1": //Camera
                Console.Write("MaxFps: ");
                int maxFps = Convert.ToInt32(GetValidInput());

                Console.Write("lenseType: ");
                var lenseType = GetValidInput();

                EquipmentService.AddNewCamera(name, yearOfPurchase, responsibleEmployee, maxFps, lenseType);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("CAMERA CREATED");
                Console.ResetColor();
                break;
            case "2": //Laptop
                Console.Write("MaxFps: ");
                int screenHz = Convert.ToInt32(GetValidInput());

                Console.Write("Has TouchPad? (1-true 2-false): ");
                var hasTouchPadUserInput = GetValidInput();
                bool? hasTouchPad = hasTouchPadUserInput switch
                {
                    "1" => true,
                    "2" => false,
                    _ => null
                };

                EquipmentService.AddNewLaptop(name, yearOfPurchase, responsibleEmployee, screenHz, hasTouchPad);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("LAPTOP CREATED");
                Console.ResetColor();
                break;
            case "3": //Projector
                Console.Write("Is Mobile? (1-true 2-false): ");
                var isMobileUserInput = GetValidInput();
                bool? isMobile = isMobileUserInput switch
                {
                    "1" => true,
                    "2" => false,
                    _ => null
                };

                Console.Write("brightness in lumens: ");
                var brightness = Convert.ToInt32(GetValidInput());

                EquipmentService.AddNewProjector(name, yearOfPurchase, responsibleEmployee, isMobile, brightness);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PROJECTOR CREATED");
                Console.ResetColor();
                break;
            default:
                Console.WriteLine("Wrong equipment type. Try again.");
                break;
        }


        Console.WriteLine("Naciśnij dowolny klawisz, aby wrócić...");
        Console.ReadKey();
    }


    private static string GetValidInput()
    {
        string? input;
        do
        {
            input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Values can't be empty. Try again.");
            }
        } while (string.IsNullOrWhiteSpace(input));

        return input;
    }
}