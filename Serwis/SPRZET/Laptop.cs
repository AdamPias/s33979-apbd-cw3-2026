namespace Serwis;

using System;
public class Laptop : Sprzet
{
    public Laptop(string nazwa, double kara, int ram, string procesor)
        : base(nazwa, kara)
    {
        this.Procesor = procesor;
        this.Ram = ram;
    }

    public int Ram { get; set; }
    public String Procesor  { get; set; }
    
}