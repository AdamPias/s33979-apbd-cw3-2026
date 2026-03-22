namespace Serwis;

using System;
public class Mikrofon : Sprzet
{
    public Mikrofon(string nazwa, double kara, String przetwornik, String pasmo) 
        : base(nazwa, kara)
    {
        this.Pasmo = pasmo;
        this.Przetwornik = przetwornik;

    }
    
    public String Przetwornik { get; set; }
    public String Pasmo { get; set; }
}