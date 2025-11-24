namespace proiectPOO_lasttouches

{


    public class SistemRezervare
    {
        // Lista care conține toate locurile disponibile pentru rezervare (de birou, parcare etc.)
        private List<Loc> Locuri = new List<Loc>();

        public List<Loc> locuri {
            get{return Locuri;}
            set{Locuri=value;}
        }

        // Metoda AdaugaLoc adaugă un loc nou în lista de locuri disponibile.
        public void AdaugaLoc(Loc loc)
        {
            Locuri.Add(loc); // Adăugăm locul în lista Locuri
            Console.WriteLine($"Locul {loc.nume} a fost adaugat cu succes."); // Mesaj de confirmare
        }

        // Metoda AfiseazaLocuri afișează toate locurile disponibile. 
        public void AfiseazaLocuri()
        {
            // Dacă nu sunt locuri disponibile, se afișează un mesaj corespunzător.
            if (Locuri.Count == 0)
            {
                Console.WriteLine("Nu exista locuri disponibile.");
            }
            else
            {
                // Dacă există locuri disponibile, le afișăm pe toate
                Console.WriteLine("Locuri disponibile:");
                foreach (var loc in Locuri)
                {
                    Console.WriteLine(loc.ToString()); // Afișăm detaliile fiecărui loc
                }
            }
        }

        // Metoda RezervaLoc rezervă un loc pentru un angajat, în funcție de ID-ul locului.
        public bool RezervaLoc(int idLoc, Angajat angajat)
        {
            // Căutăm locul după ID
            var loc = Locuri.FirstOrDefault(l => l.id == idLoc);

            // Verificăm dacă locul există și nu este deja rezervat
            if (loc != null && !loc.esteRezervat)
            {
                // Dacă locul este disponibil, îl rezervăm și îl adăugăm în lista de rezervări a angajatului
                loc.esteRezervat = true;
                angajat.AddRezervare(loc); // Adaugă locul la rezervările angajatului
                return true; // Rezervarea a fost realizată cu succes
            }

            return false; // Locul nu este disponibil pentru rezervare
        }

        // Metoda ModificaLoc permite modificarea unui loc, cum ar fi schimbarea statutului de rezervare și actualizarea numelui.
        public bool ModificaLoc(int idLoc, bool esteRezervat, string numeNou)
        {
            // Căutăm locul după ID
            var loc = Locuri.FirstOrDefault(l => l.id == idLoc);

            // Dacă locul există, actualizăm informațiile
            if (loc != null)
            {
                loc.esteRezervat = esteRezervat; // Modificăm statutul de rezervare
                loc.nume = numeNou; // Schimbăm numele locului
                return true; // Modificările au fost aplicate cu succes
            }

            return false; // Locul nu a fost găsit pentru a aplica modificările
        }
    }
}