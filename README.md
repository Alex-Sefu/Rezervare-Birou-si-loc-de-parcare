# Rezervare-Birou-si-loc-de-parcare
Proiectul este un sistem complex de gestionare a rezervărilor pentru locuri de muncă și parcare, utilizând o structura POO. La baza sa se află clasa SistemRezervare,
care gestionează locurile disponibile și 
permite rezervarea acestora de
către utilizatori. Aceasta include metode pentru adăugarea și modificarea locurilor, precum și pentru gestionarea statutului 
acestora (rezervat sau disponibil).

Clasa ParcarePublica extinde funcționalitățile SistemRezervare pentru a implementa rezervări pentru locuri de parcare,
permițând utilizatorilor să rezerve locuri cu taxă. Aceasta interacționează cu harta locurilor (HartaLocuri), care are rolul de a 
afisa și gestiona dispunerea locurilor pe o matrice, facilitând procesul de rezervare și vizualizare.

Un alt modul important este reprezentat de clasa Rezervare, care păstrează informațiile legate de fiecare rezervare efectuată,
incluzând ID-ul locului, numele angajatului și data rezervării. Angajat și Manager sunt două clase care definesc utilizatorii sistemului,
iar funcțiile acestora sunt gestionate prin intermediul metodelor precum AddRezervare. De asemenea, clasa Administrator oferă un
rol esențial în administrarea și modificarea locurilor și rezervărilor.

Interfața sistemului este controlată printr-un meniu principal, care permite utilizatorilor să aleagă acțiuni specifice în funcție
de rolul lor: angajat, manager, administrator sau utilizator al unei parcări publice sau a unui spațiu de coworking.

Sistemul este robust și flexibil, oferind o interfață prietenoasă și multiple funcționalități esențiale pentru gestionarea
locurilor de muncă și a parcurilor publice sau spațiilor de coworking. Acesta poate fi extins cu ușurință pentru a adăuga
noi tipuri de locuri sau funcționalități suplimentare.
