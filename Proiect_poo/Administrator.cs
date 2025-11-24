namespace proiectPOO_lasttouches
{
    
    public class Administrator
    {
        // Metoda VizualizeazaToateLocurile permite administratorului să vizualizeze toate locurile din sistem.
        public void VizualizeazaToateLocurile(SistemRezervare sistem)
        {
            Console.WriteLine("=== Vizualizare toate locurile ===");
            
            sistem.AfiseazaLocuri();
            
            Console.WriteLine("Apasa orice tasta pentru a continua...");
            Console.ReadKey();
        }

        // Metoda EditareLoc permite administratorului să modifice informațiile unui loc din sistem.
        public void EditareLoc(SistemRezervare sistem, int idLoc, string numeNou, bool esteRezervat)
        {
            // Căutăm locul după ID în lista Locuri a sistemului
            var loc = sistem.locuri.FirstOrDefault(l => l.id == idLoc);

            // Verificăm dacă locul a fost găsit
            if (loc != null)
            {
                loc.nume = numeNou;
                loc.esteRezervat = esteRezervat;

                Console.WriteLine($"Locul {idLoc} a fost modificat.");
            }
            else
            {
                Console.WriteLine("Locul nu a fost gasit.");
            }

            Console.WriteLine("Apasa orice tasta pentru a continua...");
            Console.ReadKey();
        }
    }
}