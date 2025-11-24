namespace proiectPOO_lasttouches

// Clasa CoworkingSpace extinde funcționalitățile clasei SistemRezervare, adăugând metode
// specifice pentru rezervarea locurilor de coworking și afișarea hărții locurilor.


{

    public class CoworkingSpace : SistemRezervare
    {
        // Metoda permite rezervarea unui loc de coworking de tip "Birou" pentru un angajat.

        public bool RezervaLocCoworking(int idLoc, Angajat angajat, HartaLocuri hartaLocuri)
        {
            // Caută un loc disponibil de tip "Birou" pe baza ID-ului.
            var loc = locuri.FirstOrDefault(l => l.id == idLoc && l.tip == "Birou");
            if (loc != null && !loc.esteRezervat) // Verifică dacă locul este disponibil.
            {
                loc.esteRezervat = true;
                angajat.AddRezervare(loc);

                // Actualizează harta locurilor pentru a reflecta rezervarea.
                int linie = (idLoc - 1) / hartaLocuri.GetNrColoane(); // Determină linia pe hartă.
                int coloana = (idLoc - 1) % hartaLocuri.GetNrColoane(); // Determină coloana pe hartă.
                hartaLocuri.RezervaLoc(linie, coloana); // Rezervă locul pe hartă.
                return true;
            }

            Console.WriteLine($"Locul {idLoc} nu este disponibil pentru rezervare.");
            return false;
        }

        // Metoda afișează harta locurilor de coworking utilizând funcționalitatea oferită de HartaLocuri.
        public void AfiseazaHartaLocuri(HartaLocuri hartaLocuri)
        {
            Console.WriteLine("=== Harta locurilor de coworking ===");
            hartaLocuri.AfiseazaHarta(); // Afișează harta locurilor.
        }

        // Suprascrie metoda de rezervare pentru a utiliza logica de bază din SistemRezervare.
        public bool RezervaLocCoworking(int idLoc, Angajat angajat)
        {
            return RezervaLoc(idLoc, angajat); // Apelează metoda RezervaLoc din clasa de bază.
        }
    }
}