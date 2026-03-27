# Rental System - APBD02

## Opis projektu

Projekt przedstawia implementację systemu do wypożyczania sprzętu.

Projekt podzielony jest w stylu Model-View-Controller, który znamy dobrze z Javy.

Sekcja Models zawiera podstawowe modele struktur, na których pracujemy. Wykorzystuję tam też klasy abstrakcyjne.

Następnie do każdej grupy modeli mamy klasy serwisowe, które dbają o logikę biznesową.

Na samym końcu mamy klasę Menu, gdzie zajmujemy się wszystkimi odnogami naszego menu i wywołaniem odpowiednich metod.

## Architektura i organizacja kodu

Podział wybrałem taki, bo wydawał mi się najbardziej znajomy i logiczny. Ładnie oddziela strefy software, o których już pisałem wyżej.

Kohezja jest całkiem dobrze zachowana za pomocą tego modelu – wiemy dokładnie, gdzie powinno być wpisane.

Coupling w naszym projekcie jest moim zdaniem umiarkowany – nie jest ani niski, ani wysoki. Niektóre zmiany wymagają zaglądania do wielu klas, ale nie zawsze.

## Jak odpalić program?

Program jest napisany z myślą o używaniu w terminalu. Wszystkie opcje wybiera się cyferkami, a dane wpisuje się jako stringi lub liczby. Wartości bool są 1 lub 2.
