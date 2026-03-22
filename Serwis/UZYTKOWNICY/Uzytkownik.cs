namespace Serwis.UZYTKOWNICY;
using System;
public abstract class Uzytkownik
{

    private static int idCounter = 1;

    protected Uzytkownik(string imie, string nazwisko, int limit)
    {
        Id = idCounter;
        Imie = imie;
        Nazwisko = nazwisko;
        Limit = limit;
        Naliczonekary = 0;
        idCounter++;
    }

    public int Id { get; private set; }
    public String Imie { get; set; }
    public String Nazwisko { get; set; }
    public int Limit { get; set; }
    public double Naliczonekary { get; set; }
}