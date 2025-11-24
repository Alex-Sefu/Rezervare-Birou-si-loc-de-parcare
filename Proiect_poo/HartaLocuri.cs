// Clasa HartaLocuri gestionează reprezentarea grafică a locurilor într-un spațiu de coworking sau parcare.
namespace proiectPOO_lasttouches
{
    public class HartaLocuri
    {
        private char[,] hartaLocuri; // Matrice care reprezintă locurile (O = liber, X = rezervat).

        // Constructorul clasei inițializează harta locurilor cu toate locurile libere ('O').
        public HartaLocuri(int nrLocuri, int numarLocuriPeLinie)
        {
            int numarLinii = (int)Math.Ceiling((double)nrLocuri / numarLocuriPeLinie);
            hartaLocuri = new char[numarLinii, numarLocuriPeLinie];

            for (int i = 0; i < hartaLocuri.GetLength(0); i++)
            {
                for (int j = 0; j < hartaLocuri.GetLength(1); j++)
                {
                    if (i * numarLocuriPeLinie + j < nrLocuri)
                    {
                        hartaLocuri[i, j] = 'O'; // Loc liber.
                    }
                }
            }
        }

        // Metoda returnează numărul de coloane din matricea hărții.
        public int GetNrColoane()
        {
            return hartaLocuri.GetLength(1);
        }

        // Metoda rezervă un loc specific (linie și coloană) marcându-l cu 'X'.
        public void RezervaLoc(int linie, int coloana)
        {
            if (hartaLocuri[linie, coloana] == 'O')
            {
                hartaLocuri[linie, coloana] = 'X';
            }
            else
            {
                Console.WriteLine("Locul este deja rezervat.");
            }
        }

        // Metoda eliberează un loc specific (linie și coloană) marcându-l cu 'O'.
        public void ElibereazaLoc(int linie, int coloana)
        {
            if (hartaLocuri[linie, coloana] == 'X')
            {
                hartaLocuri[linie, coloana] = 'O';
            }
            else
            {
                Console.WriteLine("Locul este deja liber.");
            }
        }

        // Metoda verifică dacă un loc este disponibil.
        public bool EsteLocDisponibil(int linie, int coloana)
        {
            return hartaLocuri[linie, coloana] == 'O';
        }

        // Metoda afișează harta locurilor în consolă (O = liber, X = rezervat).
        public void AfiseazaHarta()
        {
            Console.WriteLine("=== Harta locurilor ===");
            for (int i = 0; i < hartaLocuri.GetLength(0); i++)
            {
                for (int j = 0; j < hartaLocuri.GetLength(1); j++)
                {
                    Console.Write(hartaLocuri[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Metoda calculează numărul total de locuri disponibile.
        public int NumarLocuriDisponibile()
        {
            int count = 0;
            for (int i = 0; i < hartaLocuri.GetLength(0); i++)
            {
                for (int j = 0; j < hartaLocuri.GetLength(1); j++)
                {
                    if (hartaLocuri[i, j] == 'O')
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        // Metoda rezervă un loc pe baza unui ID (calculând linia și coloana).
        public bool RezervaLocPeID(int idLoc)
        {
            int linie = (idLoc - 1) / GetNrColoane();
            int coloana = (idLoc - 1) % GetNrColoane();

            if (linie >= hartaLocuri.GetLength(0) || coloana >= hartaLocuri.GetLength(1))
            {
                Console.WriteLine("ID-ul locului este invalid.");
                return false;
            }

            if (EsteLocDisponibil(linie, coloana))
            {
                RezervaLoc(linie, coloana);
                return true;
            }

            Console.WriteLine("Locul cu ID-ul specificat nu este disponibil.");
            return false;
        }
    }
}
