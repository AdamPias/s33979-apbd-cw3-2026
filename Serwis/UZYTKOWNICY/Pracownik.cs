namespace Serwis.UZYTKOWNICY;

using System;
public class Pracownik : Uzytkownik
{
    public Pracownik(string imie, string nazwisko, string rola, double wynagrodzenie) : base( imie, nazwisko, 5)
    {
        Rola = rola;
        Wynagrodzenie = wynagrodzenie;
    }

    public String Rola { get; set; }
    public double Wynagrodzenie { get; set; }
    
    public override string ToString()
    {
        return $"ID: {Id} | Imie: {Imie} | Nazwisko: {Nazwisko} | Rola: {Rola} | Wynagrodzenie: {Wynagrodzenie}";
    }
    
}