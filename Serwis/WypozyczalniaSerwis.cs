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

    public void ZwrocSprzet(Wypozyczenie wypozyczenie)
    {
        
    }
}