using System;

namespace LibrarieClient
{
    public class Client
    {
        //constante
        private const bool SUCCES = true;
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';

        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int xCNP = 3;
        private const int SOLD = 4;
        private const int PERIOADADEPOZIT = 5;
        private const int TELEFON = 6;
        private const int EMAIL = 7;

        static Random numar = new Random();

        public static int nrClienti = 0;
        public string soldCont { get; set; }
        public string perioadaDepozitare { get; set; }
        public int IDClient { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string NumeComplet { get { return Nume + " " + Prenume; } }

        public Client()
        {
            IDClient = (numar.Next(10000000, 100000000) + 165448401) / numar.Next(1, 15) + 13;
            Nume = string.Empty;
            Prenume = string.Empty;
            CNP = string.Empty;
            soldCont = string.Empty;
            perioadaDepozitare = string.Empty;
            Telefon = string.Empty;
            Email = string.Empty;
            nrClienti++;
        }

        public Client(string _Nume, string _Prenume, string _CNP, string _soldCont, string _perioadaDepozitare, string _telefon, string _email)
        {
            IDClient = (numar.Next(10000000, 100000000) + 165448401) / numar.Next(1, 15) + 13;
            Nume = _Nume;
            Prenume = _Prenume;
            CNP = _CNP;
            soldCont = _soldCont;
            perioadaDepozitare = _perioadaDepozitare;
            Telefon = _telefon;
            Email = _email;

            nrClienti++;
        }

        public Client(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ToString()
            IDClient = Convert.ToInt32(dateFisier[ID]);
            Nume = dateFisier[NUME];
            Prenume = dateFisier[PRENUME];
            CNP = dateFisier[xCNP];
            soldCont = dateFisier[SOLD];
            perioadaDepozitare = dateFisier[PERIOADADEPOZIT];
            Telefon = dateFisier[TELEFON];
            Email = dateFisier[EMAIL];

            nrClienti++;
        }
        private float Dobanda
        {
            get
            {
                return float.Parse(perioadaDepozitare) * 63 / 932 % 100;
            }
        }


        public string ConversieLaSir()
        {          
            string sirConversie = string.Format("\n\n----------------------------------------------------------------\n\nID Client               :   {0}\nNume                   :    {1}\nPrenume              :    {2}\nCNP                     :   {3}\nSold Curent          :   {4} LEI\nPerioada Depozit  :   {5} luni\nDobanda              :   {6}%\n\nSold la finalul depozitului: {7} LEI.\n\n----------------------------------------------------------------\n", IDClient, Nume, Prenume, CNP, soldCont, perioadaDepozitare, Dobanda, getSoldFinalPerioada);
            return sirConversie;
        }

        public float addSumaSoldCont(float _sumaBani)
        {
            float.Parse(soldCont += _sumaBani);
            return float.Parse(soldCont);
        }

        public float getSoldFinalPerioada
        {
            get
            {
                return float.Parse(soldCont) + float.Parse(soldCont) * Dobanda / 100;
            }
        }

        public string ConversieLaSir_PentruFisier()
        {
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}",
                SEPARATOR_PRINCIPAL_FISIER, IDClient.ToString(), (Nume ?? " NECUNOSCUT "), (Prenume ?? " NECUNOSCUT "), (CNP ?? " NECUNOSCUT "), (soldCont ?? " NECUNOSCUT "), (perioadaDepozitare ?? " NECUNOSCUT "), (Telefon ?? " NECUNOSCUT "), (Email ?? " NECUNOSCUT "));

            return s;
        }
    }
}
