namespace Serwis.UZYTKOWNICY;
using System;
public class Student : Uzytkownik
{
    public Student(string imie, string nazwisko, String ska, int semestr) : base( imie, nazwisko, 2)
    {
        this.Semestr = semestr;
        this.Ska = ska;
    }
    
    public String Ska { get; set; }
    public int Semestr { get; set; }

    public override string ToString()
    {
        return $"ID: {Id} | Imie: {Imie} | Nazwisko: {Nazwisko} | Ska: {Ska} | Semestr: {Semestr}";
    }
}