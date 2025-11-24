namespace proiectPOO_lasttouches
{
    public static class Menu
    {
        public static void ParcarePublicaActions(ParcarePublica parcare, HartaLocuri hartaLocuri, Angajat angajat)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Meniu Parcare Publica ===");
                Console.WriteLine("1. Vizualizeaza locuri");
                Console.WriteLine("2. Rezerva loc");
                Console.WriteLine("3. Afiseaza harta locuri");
                Console.WriteLine("4. Inapoi");
                Console.Write("Alegeti o optiune (1-4): ");
                var alegere = Console.ReadLine();

                switch (alegere)
                {
                    case "1":
                        parcare.AfiseazaLocuri();
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Write("Introduceti ID-ul locului pe care doriti sa-l rezervati: ");
                        var idLoc = int.Parse(Console.ReadLine());
                        parcare.RezervaLocCuTaxa(idLoc, angajat, hartaLocuri);
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "3":
                        hartaLocuri.AfiseazaHarta();
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "4":
                        return; // Revenire la meniul anterior
                    default:
                        Console.WriteLine("Optiune invalida! Apasati orice tasta pentru a incerca din nou.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Meniu pentru Coworking Space
        public static void CoworkingSpaceActions(CoworkingSpace coworking, HartaLocuri hartaLocuri, Angajat angajat)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Meniu Coworking Space ===");
                Console.WriteLine("1. Vizualizeaza locuri");
                Console.WriteLine("2. Rezerva loc");
                Console.WriteLine("3. Afiseaza harta locuri");
                Console.WriteLine("4. Inapoi");
                Console.Write("Alegeti o optiune (1-4): ");
                var alegere = Console.ReadLine();

                switch (alegere)
                {
                    case "1":
                        coworking.AfiseazaLocuri();
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Write("Introduceti ID-ul locului pe care doriti sa-l rezervati: ");
                        var idLoc = int.Parse(Console.ReadLine());
                        coworking.RezervaLocCoworking(idLoc, angajat, hartaLocuri);
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "3":
                        hartaLocuri.AfiseazaHarta();
                        break;
                    case "4":
                        return; // Înapoi la meniul anterior
                    default:
                        Console.WriteLine("Optiune invalida! Apasati orice tasta pentru a incerca din nou.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Meniu pentru Angajat
        public static void AngajatActions(SistemRezervare sistem, Angajat angajat, HartaLocuri hartaLocuri)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"=== Meniu {angajat.numee} ===");
                Console.WriteLine("1. Vizualizeaza locuri");
                Console.WriteLine("2. Rezerva loc");
                Console.WriteLine("3. Vizualizeaza rezervarile tale");
                Console.WriteLine("4. Afiseaza harta locurilor");
                Console.WriteLine("5. Inapoi");
                Console.Write("Alegeti o optiune (1-5): ");
                var alegere = Console.ReadLine();

                switch (alegere)
                {
                    case "1":
                        sistem.AfiseazaLocuri();
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Write("Introduceti ID-ul locului pe care doriti sa-l rezervati: ");
                        var idLoc = int.Parse(Console.ReadLine());
                        if (sistem.RezervaLoc(idLoc, angajat))
                        {
                            Console.WriteLine("Rezervarea a fost realizata cu succes.");
                        }
                        else
                        {
                            Console.WriteLine("Rezervarea nu a fost posibila.");
                        }
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "3":
                        angajat.AfiseazaRezervari();
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "4":
                        hartaLocuri.AfiseazaHarta();
                        break;
                    case "5":
                        return; // Înapoi la meniul anterior
                    default:
                        Console.WriteLine("Optiune invalida! Apasati orice tasta pentru a incerca din nou.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Meniu pentru Manager
        public static void ManagerActions(Manager manager, HartaLocuri hartaLocuri)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"=== Meniu Manager: {manager.numee} ===");
                Console.WriteLine("1. Vizualizeaza rezervarile echipei");
                Console.WriteLine("2. Modifica rezervare echipa");
                Console.WriteLine("3. Sterge rezervare echipa");
                Console.WriteLine("4. Afiseaza harta locurilor");
                Console.WriteLine("5. Inapoi");
                Console.Write("Alegeti o optiune (1-5): ");
                var alegere = Console.ReadLine();

                switch (alegere)
                {
                    case "1":
                        manager.VizualizeazaRezervariEchipa();
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Write("Introduceti ID-ul locului de rezervare pe care doriti să-l modificati: ");
                        var idLoc = int.Parse(Console.ReadLine());
                        Console.Write("Introduceti noua locatie a locului: ");
                        var locatieNoua = Console.ReadLine();
                        Console.Write("Este locul rezervat? (da/nu): ");
                        var rezervat = Console.ReadLine().ToLower() == "da";

                        manager.ModificaRezervareEchipa(idLoc, rezervat, locatieNoua);
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Write("Introduceti ID-ul locului de rezervare pe care doriti să-l stergeti: ");
                        idLoc = int.Parse(Console.ReadLine());
                        manager.StergeRezervareEchipa(idLoc);
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "4":
                        hartaLocuri.AfiseazaHarta();
                        break;
                    case "5":
                        return; // Înapoi la meniul anterior
                    default:
                        Console.WriteLine("Optiune invalida! Apasati orice tasta pentru a incerca din nou.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // Meniu pentru Administrator
        public static void AdministratorActions(Administrator administrator, SistemRezervare sistem, HartaLocuri hartaLocuri)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Meniu Administrator ===");
                Console.WriteLine("1. Vizualizeaza toate locuri");
                Console.WriteLine("2. Modifica loc");
                Console.WriteLine("3. Afiseaza harta locurilor");
                Console.WriteLine("4. Inapoi");
                Console.Write("Alegeti o optiune (1-4): ");
                var alegere = Console.ReadLine();

                switch (alegere)
                {
                    case "1":
                        administrator.VizualizeazaToateLocurile(sistem);
                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Write("Introduceti ID-ul locului pe care doriti să-l modificati: ");
                        var idLoc = int.Parse(Console.ReadLine());

                        var loc = sistem.locuri.FirstOrDefault(l => l.id == idLoc);
                        if (loc != null)
                        {
                            Console.Write("Introduceti noua locatie a locului: ");
                            var locatieNoua = Console.ReadLine();
                            Console.Write("Este locul rezervat? (da/nu): ");
                            var rezervat = Console.ReadLine().ToLower() == "da";

                            administrator.EditareLoc(sistem, idLoc, locatieNoua, rezervat);
                        }
                        else
                        {
                            Console.WriteLine("Locul nu a fost gasit!");
                        }

                        Console.WriteLine("Apasa orice tasta pentru a continua...");
                        Console.ReadKey();
                        break;
                    case "3":
                        hartaLocuri.AfiseazaHarta();
                        break;
                    case "4":
                        return; // Înapoi la meniul anterior
                    default:
                        Console.WriteLine("Optiune invalida! Apasati orice tasta pentru a incerca din nou.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
