using Serwis.UZYTKOWNICY;
using System;
namespace Serwis;

public class Wypozyczenie
{
    public Wypozyczenie(Uzytkownik kto, Sprzet co, DateTime dataWypozyczenia, DateTime terminZwrotu)
    {
        Kto = kto;
        Co = co;
        DataWypozyczenia = dataWypozyczenia;
        TerminZwrotu = terminZwrotu;
    }

    public Uzytkownik Kto { get; set; }
    public Sprzet Co { get; set; }
    public DateTime DataWypozyczenia { get; set; }
    public DateTime TerminZwrotu { get; set; }
    public DateTime? Zwrocono { get; set; }

    public override string ToString()
    {
        if (Zwrocono is null)
        {
            return $"Wypozycznie Uzytkownika: {Kto}\nSprzet: {Co} | Data Wypozycznie: {DataWypozyczenia} | Zwrocono: Nie zwrocono";
        }
        return $"Wypozycznie Uzytkownika: {Kto}\nSprzet: {Co} | Data Wypozycznie: {DataWypozyczenia} | Zwrocono: {Zwrocono}";
    }
}