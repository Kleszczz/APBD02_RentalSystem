// See https://aka.ms/new-console-template for more information

/*
Przygotuj aplikację konsolową w C#, która obsługuje uczelnianą wypożyczalnię sprzętu. 
System ma pozwalać na 
- rejestrowanie sprzętu, 
- wypożyczanie go użytkownikom, 
- zwroty, 
- kontrolę dostępności
- generowanie podstawowych raportów.
    
W systemie występują różne typy sprzętu, a każda kategoria ma część cech wspólnych i część cech
specyficznych. To jest dobry moment, żeby zastanowić się, co powinno być wspólne, co powinno być
    wyspecjalizowane i gdzie rzeczywiście opłaca się użyć dziedziczenia, a gdzie lepsza będzie
        kompozycja albo osobna klasa serwisowa.
*/

using APBD02_RentalSystem;
using APBD02_RentalSystem.Equipments;
using APBD02_RentalSystem.Users;

List<Equipment> equipments = [];
List<AbstractPerson> users = [];
List<Rental> rentals = [];

Console.WriteLine("Hello, World!");