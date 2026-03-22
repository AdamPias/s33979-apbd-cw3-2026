using System;
using Serwis;
using Serwis.UZYTKOWNICY;

WypozyczalniaSerwis serwis = new WypozyczalniaSerwis();

Laptop laptop1 = new Laptop("Razer67", 200, 32, "Intel Core i5-12400F");
Laptop laptop2 = new Laptop("Laptop HP OmniBook 5", 100, 16, "AMD Ryzen™ 5 8540U");

Mikrofon mikrofon1 = new Mikrofon("Krux Edis 1000", 100, "Pojemnosciowy", "20Hz - 20kHz");
Mikrofon mikrofon2 = new Mikrofon("Neumann M 50 V Set", 1000, "Gradientu cisnienia", "20Hz - 16kHz");

Aparat aparat1 = new Aparat("SONY Alpha A7 III", 300, "Pełna klatka (35.8 x 23.8 mm)", 6000*4000);
Aparat aparat2 = new Aparat("CANON EOS R6 Mark II", 500, "Pełna klatka (35.9 x 23.9 mm)", 8000*6000);


Student student1 = new Student("Adam", "Cwikla", "s33979", 4);
Student student2 = new Student("Marek", "Warek", "s41245", 2);

Pracownik pracownik1 = new Pracownik("Wiktor", "Kaczynski", "Manager", 6500);
Pracownik pracownik2 = new Pracownik("Kacper", "Walaszek", "Kasjer", 3000);

serwis.DodajSprzet(laptop1);
serwis.DodajSprzet(laptop2);
serwis.DodajSprzet(mikrofon1);
serwis.DodajSprzet(mikrofon2);
serwis.DodajSprzet(aparat1);
serwis.DodajSprzet(aparat2);

serwis.DodajUzytkownika(student1);
serwis.DodajUzytkownika(student2);
serwis.DodajUzytkownika(pracownik1);
serwis.DodajUzytkownika(pracownik2);

serwis.DodajWypozyczenie(student1, laptop1, 14);
Console.WriteLine("----------------------------");
serwis.DodajWypozyczenie(student1, mikrofon1, 20);
Console.WriteLine("----------------------------");

Console.WriteLine("Proba wypozyczenia wiecej urzadzen niz ma sie limit:");
serwis.DodajWypozyczenie(student1, aparat1, 5);
Console.WriteLine("----------------------------");

Console.WriteLine("Proba wynajecia juz wynajetego sprzetu:");
serwis.DodajWypozyczenie(student2, laptop1, 7);
Console.WriteLine("----------------------------");

Console.WriteLine("Zwrocenie sprzetu:");
serwis.ZwrocSprzet(laptop1);
Console.WriteLine("----------------------------");

Console.WriteLine("Ustawienie statusu niedsotepny dla sprzetu:");
serwis.NiedostepnySprzet(laptop1);
Console.WriteLine("----------------------------");

Console.WriteLine("Proba wynajecia niedostepnego sprzetu:");
serwis.DodajWypozyczenie(pracownik2, laptop1, 29);
Console.WriteLine("----------------------------");


serwis.DodajWypozyczenie(pracownik2, laptop2, -7);
Console.WriteLine("----------------------------");

serwis.DodajWypozyczenie(pracownik2, mikrofon2, -14);
Console.WriteLine("----------------------------");

Console.WriteLine("Zwrocenie sprzetu po terminie:");
serwis.ZwrocSprzet(laptop2);
Console.WriteLine("----------------------------");

Console.WriteLine("Aktywne wypozyczenia uzytkownika: " + student1.Id);
serwis.AktywneWypozyczeniaUzytkownika(student1);
Console.WriteLine("----------------------------");

Console.WriteLine("Przeterminowane wypozyczenia: ");
serwis.Przeterminowane();

Console.WriteLine("----------------------------");
serwis.GenerujRaport();


