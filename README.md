System Zarządzania Wypożyczalnią Sprzętu

Opis projektu
Aplikacja konsolowa napisana w języku C#, służąca do zarządzania wypożyczalnią sprzętu (np. na uczelni). System umożliwia ewidencję sprzętu, zarządzanie użytkownikami (studentami i pracownikami), obsługę wypożyczeń, weryfikację dostępności oraz naliczanie ewentualnych kar za przetrzymanie sprzętu po terminie.

Uzasadnienie decyzji projektowych
W trakcie realizacji projektu podjęto następujące decyzje architektoniczne i logiczne:

1. Abstrakcja i Dziedziczenie (Modele)
   Klasy Sprzet oraz Uzytkownik zostały zadeklarowane jako abstrakcyjne. Wynika to z faktu, że w systemie nie może istnieć "ogólny sprzęt" ani "ogólny użytkownik" – zawsze musi to być konkretny podtyp (np. Laptop, Student). Pozwoliło to na wydzielenie wspólnych właściwości (np. Id, Nazwa) do klas bazowych, co znacząco zredukowało powtarzalność kodu.

2. Oddzielenie logiki biznesowej (Klasa Serwisowa)
   Zamiast umieszczać logikę wypożyczania bezpośrednio w klasach modeli lub w głównym pliku programu, utworzono dedykowaną klasę WypozyczalniaSerwis. Modele służą wyłącznie do przechowywania danych, a serwis zarządza listami i operacjami (dodawanie, wypożyczanie, zwroty, kary). Zwiększa to czytelność kodu i ułatwia jego późniejszą rozbudowę.

4. Elastyczność czasu wypożyczeń i obsługa braków
   Data zwrotu nie jest sztywno zdefiniowana w systemie, lecz podawana jako parametr (ilość dni) podczas wypożyczania, co pozwala na różne scenariusze biznesowe. Zmienna Zwrocono w klasie Wypozyczenie używa typu DateTime? (nullable). Wartość null idealnie i naturalnie reprezentuje stan, w którym sprzęt jest nadal w rękach użytkownika.

Scenariusz testowy
W pliku głównym Main.cs zaimplementowano scenariusz demonstracyjny, który weryfikuje poprawne oraz błędne operacje (np. próba przekroczenia limitu wypożyczeń przez studenta, naliczenie kary za opóźniony zwrot, generowanie raportu końcowego).

Organizacja pracy
Praca nad projektem została podzielona na gałęzie robocze, na przyklad dla logiki biznesowej oraz scenariusza demonstracyjnego. Po zakończeniu prac gałęzie te zostały pomyślnie scalone z gałęzią główną master.
