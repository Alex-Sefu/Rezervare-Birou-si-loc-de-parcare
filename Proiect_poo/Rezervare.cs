namespace proiectPOO_lasttouches

{
    // Clasa Rezervare reprezintă o rezervare pentru un loc de muncă sau un loc de parcare.
    public class Rezervare
    {

        private int IdLoc;

        public int idLoc
        {
            get { return IdLoc; }
            set { IdLoc = value; }
        }
        private string NumeAngajat;

        public string numeAngajat
        {
            get { return NumeAngajat; }
            set { NumeAngajat = value; }
        }

        private DateTime DataRezervarii;

        public DateTime dataRezervarii
        {
            get { return DataRezervarii; }
            set { DataRezervarii = value; }
        }

        private bool EsteLocParcare;

        public bool esteLocParcare
        {
            get { return EsteLocParcare; }
            set { EsteLocParcare = value; }
        }
    }
}