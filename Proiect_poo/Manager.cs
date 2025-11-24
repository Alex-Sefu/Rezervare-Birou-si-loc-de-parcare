namespace proiectPOO_lasttouches;

// Clasa Manager extinde funcționalitățile clasei Angajat.
// Managerul are o listă de angajați în echipa sa și funcționalități suplimentare
// pentru a vizualiza, modifica și șterge rezervările acestora.
public class Manager : Angajat
{
    // Proprietatea Angajati reprezintă lista de angajați din echipa managerului.
    private List<Angajat> Angajati { get; set; }

    // Constructorul inițializează un Manager cu numele său și lista de angajați din echipă.
  
    public Manager(string nume, List<Angajat> angajati) : base(nume)
    {
        Angajati = angajati;
    }

    // Metoda VizualizeazaRezervariEchipa afișează toate rezervările angajaților din echipa managerului.
    public void VizualizeazaRezervariEchipa()
    {
        Console.WriteLine($"{numee} - Rezervarile echipei:");
        // Iterează prin fiecare angajat din echipă și afișează rezervările acestuia.
        foreach (var angajat in Angajati)
        {
            angajat.AfiseazaRezervari(); // Utilizează metoda din clasa Angajat.
        }
    }

    // Metoda ModificaRezervareEchipa permite managerului să modifice o rezervare a unui angajat.
    public void ModificaRezervareEchipa(int idLoc, bool esteRezervat, string numeNou)
    {
        // Caută rezervarea în lista de rezervări a fiecărui angajat.
        foreach (var angajat in Angajati)
        {
            var loc = angajat.rezervari.FirstOrDefault(l => l.id == idLoc);
            if (loc != null) // Dacă rezervarea este găsită:
            {
                loc.esteRezervat = esteRezervat; 
                loc.nume = numeNou; 
                Console.WriteLine($"Rezervarea pentru locul {idLoc} a fost modificata.");
                return; 
            }
        }
        
        Console.WriteLine("Rezervarea nu a fost gasita.");
    }

    // Metoda StergeRezervareEchipa permite managerului să șteargă o rezervare a unui angajat.
    public void StergeRezervareEchipa(int idLoc)
    {
        // Caută rezervarea în lista de rezervări a fiecărui angajat.
        foreach (var angajat in Angajati)
        {
            var loc = angajat.rezervari.FirstOrDefault(l => l.id == idLoc);
            if (loc != null) // Dacă rezervarea este găsită:
            {
                angajat.rezervari.Remove(loc); // Elimină locul din lista de rezervări.
                Console.WriteLine($"Rezervarea pentru locul {idLoc} a fost stearsa.");
                return; // Termină metoda după ștergere.
            }
        }
        // Dacă rezervarea nu este găsită:
        Console.WriteLine("Rezervarea nu a fost gasita.");
    }
}