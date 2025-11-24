namespace proiectPOO_lasttouches;

public class Angajat
{

    private string Nume;
    
    private  List<Loc> Rezervari= new List<Loc>();

    // Constructorul clasei Angajat
    public Angajat(string nume)
    {
        Nume = nume;
    }

    public string numee
    {
        get{return Nume;}
        set{Nume = value;}
    }

    public List<Loc> rezervari
    {
        get{return Rezervari;}
        set{Rezervari = value;}
    }

    // Metoda AddRezervare adaugă un loc în lista de rezervări ale angajatului.
    public void AddRezervare(Loc loc)
    {
        Rezervari.Add(loc);  
    }

    // Metoda AfiseazaRezervari afișează toate rezervările efectuate de angajat.
    public void AfiseazaRezervari()
    {
        // Afișăm un mesaj care indică numele angajatului și o listă a rezervărilor sale
        Console.WriteLine($"{Nume} - Rezervarile tale:");
        
        
        if (Rezervari.Count == 0)
        {
            Console.WriteLine("Nu ai nicio rezervare.");
        }
        else
        {
          
            foreach (var rezervare in Rezervari)
            {
                Console.WriteLine(rezervare);  // Afișăm fiecare rezervare (folosind metoda ToString a clasei Loc)
            }
        }
    }
}