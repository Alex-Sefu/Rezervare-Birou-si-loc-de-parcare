namespace proiectPOO_lasttouches;

// Clasa Loc reprezintă un loc într-un spațiu de coworking.
// Fiecare loc are un ID unic, un tip (de exemplu, birou, sală de conferințe),
// un nume, un statut de rezervare și, opțional, o taxă asociată.
public class Loc
{

    private int Id;
    private string Tip;
    private string Nume;
    private bool EsteRezervat;
    private decimal? Taxa;  // Proprietatea Taxa reprezintă costul rezervării locului. Este opțională și poate fi null pentru locurile de tip birou.

    public int id
    {
        get { return Id; }
        set { Id = value; }
    }

    public string tip
    {
        get { return Tip; }
        set { Tip = value; }
    }

    public string nume
    {
        get { return Nume; }
        set { Nume = value; }
    }

    public bool esteRezervat
    {
        get { return EsteRezervat; }
        set { EsteRezervat = value; }
    }

    public decimal? taxa
    {
        get { return Taxa; }
        set { Taxa = value; }
    }
public  Loc(int id, string tip, string nume, decimal? taxa = null)
    {
        Id = id;
        Tip = tip;
        Nume = nume;
        EsteRezervat = false; // Inițial, locul este liber.
        Taxa = taxa;
    }

    // Metoda Rezervat marchează locul ca rezervat dacă acesta este disponibil.
    // Returnează true dacă locul a fost rezervat cu succes, altfel false.
    public bool Rezervat()
    {
        if (!EsteRezervat) // Verifică dacă locul nu este deja rezervat.
        {
            EsteRezervat = true; 
            return true; 
        }
        return false; 
    }

    // Metoda Elibereaza marchează locul ca fiind disponibil (ne-rezervat).
    public void Elibereaza()
    {
        EsteRezervat = false; // Locul este eliberat.
    }

    // Suprascrie metoda ToString pentru a returna o reprezentare clară a locului.
    // Exemplu: "Loc1 (Birou) - Disponibil" sau "Loc2 (Sala conferinte) - Rezervat".
    public override string ToString()
    {
        return $"{Nume} ({Tip}) - {(EsteRezervat ? "Rezervat" : "Disponibil")}";
    }
}