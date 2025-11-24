using System;
using System.Collections.Generic;

namespace proiectPOO_lasttouches
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inițializare sistem de rezervare și hărți
            var sistemRezervare = new SistemRezervare();
            var hartaParcare = new HartaLocuri(20, 5); // 20 locuri, 5 pe linie
            var hartaCoworking = new HartaLocuri(10, 5); // 10 locuri, 5 pe linie

            // Creare locuri
            sistemRezervare.AdaugaLoc(new Loc(1, "Birou", "Birou 1"));
            sistemRezervare.AdaugaLoc(new Loc(2, "Birou", "Birou 2"));
            sistemRezervare.AdaugaLoc(new Loc(3, "Parcare", "Parcare A1", 10m));
            sistemRezervare.AdaugaLoc(new Loc(4, "Parcare", "Parcare A2", 15m));

            // Creare utilizatori
            var angajat1 = new Angajat("Alex");
            var angajat2 = new Angajat("Maria");
            var manager = new Manager("David", new List<Angajat> { angajat1, angajat2 });
            var administrator = new Administrator();

            // Meniu principal
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Meniu Principal ===");
                Console.WriteLine("1. Angajat");
                Console.WriteLine("2. Manager");
                Console.WriteLine("3. Administrator");
                Console.WriteLine("4. Parcare Publica");
                Console.WriteLine("5. Coworking Space");
                Console.WriteLine("6. Iesire");
                Console.Write("Alegeti un rol (1-6): ");
                var alegere = Console.ReadLine();

                try
                {
                    switch (alegere)
                    {
                        case "1":
                            Menu.AngajatActions(sistemRezervare, angajat1, hartaCoworking);
                            break;
                        case "2":
                            Menu.ManagerActions(manager, hartaCoworking);
                            break;
                        case "3":
                            Menu.AdministratorActions(administrator, sistemRezervare, hartaParcare);
                            break;
                        case "4":
                            Menu.ParcarePublicaActions(new ParcarePublica(), hartaParcare, angajat1);
                            break;
                        case "5":
                            Menu.CoworkingSpaceActions(new CoworkingSpace(), hartaCoworking, angajat2);
                            break;
                        case "6":
                            return;
                        default:
                            Console.WriteLine("Optiune invalida! Apasati orice tasta pentru a incerca din nou.");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Introdu un numar valid.");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"A aparut o eroare neasteptata: {ex.Message}");
                    Console.ReadKey();
                }
            }
        }
    }
}
