using System;
using Serwis.UZYTKOWNICY;
using System.Collections.Generic;
namespace Serwis;

public class WypozyczalniaSerwis
{
    private List<Uzytkownik> uzytkownicy = new List<Uzytkownik>();
    private List<Sprzet> sprzety = new List<Sprzet>();
    private List<Wypozyczenie> wypozyczenia = new List<Wypozyczenie>();

    public void DodajUzytkownika(Uzytkownik nowyUzytkownik)
    {
        this.uzytkownicy.Add(nowyUzytkownik);
    }

    public void DodajSprzet(Sprzet nowySprzet)
    {
        this.sprzety.Add(nowySprzet);
    }

    public bool DodajWypozyczenie(Uzytkownik uzytkownik, Sprzet sprzet, int naIleDni)
    {
        int ile = 0;
        foreach (var wypozyczenie in wypozyczenia)
        {
            if (wypozyczenie.Kto == uzytkownik && wypozyczenie.Zwrocono is null)
            {
                ile++;
            }
        }

        if (!(sprzet.Status == "Dostepny"))
        {
            Console.WriteLine("Podany sprzet jest aktualnie nie dostępny!!");
            return false;
        }if (ile >= uzytkownik.Limit)
        {
            Console.WriteLine("Osiagnales limit wypozyczen!!!");
            return false;
        }

        sprzet.Status = "Wypozyczony";
        Wypozyczenie noweWypozyczenie = new Wypozyczenie(uzytkownik, sprzet, DateTime.Now, DateTime.Now.AddDays(naIleDni));
        wypozyczenia.Add(noweWypozyczenie);

        Console.WriteLine("Wypozyczono sprzet: " + sprzet);
        Console.WriteLine("Uzytkownikowi: " + uzytkownik);
        return true;
    }

    public void WyswietlWszystkieSprzety()
    {
        for (var i = 0; i < sprzety.Count; i++)
        {
            Console.WriteLine(sprzety[i]);
        }
    }

    public void WyswietlDostepneSprzety()
    {
        foreach (var sprzet in sprzety)
        {
            if (sprzet.Status == "Dostepny")
            {
                Console.WriteLine(sprzet);
            }
        }
    }

    public void ZwrocSprzet(Sprzet sprzet)
    {
        foreach (var wypozyczenie in wypozyczenia)
        {
            if (wypozyczenie.Co.Id == sprzet.Id && wypozyczenie.Zwrocono is null)
            {
             
                if(DateTime.Now > wypozyczenie.TerminZwrotu){
                    int ile = (DateTime.Now - wypozyczenie.TerminZwrotu).Days;
                    double kara = sprzet.Kara * ile;
                    Console.WriteLine("Naliczono : "+ kara + "zl kary");
                    wypozyczenie.Kto.Naliczonekary += kara;
                }
                wypozyczenie.Zwrocono = DateTime.Now;
                sprzet.Status = "Dostepny";
            }
        }

        Console.WriteLine("Zwrocono :" + sprzet);
    }

    public void NiedostepnySprzet(Sprzet sprzet)
    {
        int jest = 0;
        foreach (var wypozyczenie in wypozyczenia)
        {
            if (wypozyczenie.Co.Id == sprzet.Id && wypozyczenie.Zwrocono is null)
                jest++;
        }

        if (jest > 0)
        {
            Console.WriteLine("Sprzet jest aktualnie wypozyczany nie mozna go ustawic jako niedostepny!!!");
            return;
        }

        Console.WriteLine("Status sprzetu o id:" + sprzet.Id + " zostal ustawiony na niedostepny");
        sprzet.Status = "Niedostepny";

    }

    public void AktywneWypozyczeniaUzytkownika(Uzytkownik uzytkownik)
    {
        foreach (var wypozyczenie in wypozyczenia)
        {
            if (wypozyczenie.Kto.Id == uzytkownik.Id && wypozyczenie.Zwrocono is null)
            {
                Console.WriteLine(wypozyczenie);
            }
        }
    }

    public void Przeterminowane()
    {
        foreach (var wypozyczenie in wypozyczenia)
        {
            if (wypozyczenie.TerminZwrotu < DateTime.Now && wypozyczenie.Zwrocono is null)
            {
                Console.WriteLine(wypozyczenie);
            }
        }
    }

    public void GenerujRaport()
    {
        int zwroconeNaCzas = 0;
        int zwroconePoCzasie = 0;
        int nieZwrocone = 0;
    
        foreach (var wypozyczenie in wypozyczenia)
        {
            if (wypozyczenie.Zwrocono is null)
            {
                nieZwrocone++;
            }
            else if (wypozyczenie.Zwrocono <= wypozyczenie.TerminZwrotu)
            {
                zwroconeNaCzas++;
            }
            else
            {
                zwroconePoCzasie++;
            }
        }
        
        Console.WriteLine("--- RAPORT WYPOZYCZALNI ---");
        Console.WriteLine("Ilość wszystkich sprzętów: " + sprzety.Count);
        Console.WriteLine("Ilość wszystkich użytkowników: " + uzytkownicy.Count);
        Console.WriteLine("Wszystkie wypożyczenia: " + wypozyczenia.Count);
        Console.WriteLine("Wypożyczenia zwrócone na czas: " + zwroconeNaCzas);
        Console.WriteLine("Wypożyczenia zwrócone po czasie: " + zwroconePoCzasie);
        Console.WriteLine("Wypożyczenia, które nie zostały jeszcze zwrócone: " + nieZwrocone);
        Console.WriteLine("---------------------------");
    }
    
}