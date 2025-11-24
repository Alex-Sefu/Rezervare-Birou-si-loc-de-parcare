namespace proiectPOO_lasttouches
{

    public class ParcarePublica : SistemRezervare
    {
        // Proprietatea TaxaParcare este comentată, probabil nu este necesară sau nu a fost implementată încă.
        // public decimal TaxaParcare { get; set; }

        // Metoda RezervaLocCuTaxa rezerva un loc de parcare cu taxa pentru un angajat.
        public bool RezervaLocCuTaxa(int idLoc, Angajat angajat, HartaLocuri hartaLocuri)
        {
            // Căutăm locul de parcare cu ID-ul specificat și care nu este deja rezervat.
            var loc = locuri.FirstOrDefault(l => l.id == idLoc && l.tip == "Parcare");

            // Dacă locul este disponibil pentru rezervare
            if (loc != null && !loc.esteRezervat)
            {

                loc.esteRezervat = true;

                angajat.AddRezervare(loc);

                Console.WriteLine($"Locul {loc.nume} a fost rezervat. Taxa de parcare este {loc.taxa} lei.");

                // Actualizează harta locurilor pentru a reflecta rezervarea
                // Calculăm linia și coloana în harta locațiilor pentru a marca locul ca rezervat
                int linie = (idLoc - 1) / hartaLocuri.GetNrColoane(); // Linia se calculează pe baza ID-ului locului
                int coloana = (idLoc - 1) % hartaLocuri.GetNrColoane(); // Coloana se calculează pe baza ID-ului locului

                // Se rezervă efectiv locul în harta locațiilor
                hartaLocuri.RezervaLoc(linie, coloana);
                return true; // Rezervarea a fost realizată cu succes
            }

            // Dacă locul nu este disponibil, afișăm un mesaj corespunzător
            Console.WriteLine($"Locul {idLoc} nu este disponibil pentru rezervare.");
            return false; // Rezervarea nu a fost realizată
        }

        // Metoda comentată RezervaLocCoworking pare să fie o funcționalitate similară pentru locurile de coworking.
        // Publicul acestei metode este pentru un loc de coworking, dar este momentan comentată.
        // public bool RezervaLocCoworking(int idLoc, Angajat angajat, HartaLocuri hartaLocuri)
        // {
        //  if (RezervaLoc(idLoc, angajat))  // Reutilizează metoda RezervaLoc, care este probabil implementată în clasa părinte
        // {
        //   var loc = Locuri.FirstOrDefault(l => l.Id == idLoc);
        // if (loc != null)
        // {
        // Se calculează linia și coloana pentru a marca locul ca rezervat în harta locațiilor
        // int linie = (idLoc - 1) / hartaLocuri.GetNrColoane();
        // int coloana = (idLoc - 1) % hartaLocuri.GetNrColoane();
        // hartaLocuri.RezervaLoc(linie, coloana);
        // }
        //return true;  // Rezervarea a fost realizată cu succes

        //} return false; // Rezervarea nu a fost realizată
        // }

        // Metoda AfiseazaHartaLocuri afișează harta locurilor de parcare.
        public void AfiseazaHartaLocuri(HartaLocuri hartaLocuri)
        {
            // Afișăm un mesaj introductiv pentru harta locurilor de parcare
            Console.WriteLine("=== Harta locurilor de parcare ===");

            // Afișăm efectiv harta locurilor folosind metoda din clasa HartaLocuri
            hartaLocuri.AfiseazaHarta();
        }
    }
}