using Serwis.UZYTKOWNICY;

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

    public void DodajWypozyczenie(Wypozyczenie noweWypozyczenie)
    {
        this.wypozyczenia.Add(noweWypozyczenie);
    }
}