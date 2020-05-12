using System;
using System.Collections.Generic;

namespace LibrarieClient
{
    public class Client
    {
        //constante
        private const bool SUCCES = true;
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';


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
        public List<string> Carduri { get; set; }
        public raspunsTermeni raspunsTRM { get; set; }
        public int AnNastere{ get; set; }

        public string CarduriAsString
        {
            get
            {
                string cCarduri = string.Empty;

                foreach (string card in Carduri)
                {
                    if (cCarduri != string.Empty)
                    {
                        cCarduri += SEPARATOR_SECUNDAR_FISIER;
                    }
                    cCarduri += card;
                }

                return cCarduri;
            }
        }

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
            IDClient = Convert.ToInt32(dateFisier[(int)CampuriClient.ID]);
            Nume = dateFisier[(int)CampuriClient.NUME];
            Prenume = dateFisier[(int)CampuriClient.PRENUME];
            CNP = dateFisier[(int)CampuriClient.xCNP];
            AnNastere = Int32.Parse(dateFisier[(int)CampuriClient.AN_NASTERE]);
            soldCont = dateFisier[(int)CampuriClient.SOLD];
            perioadaDepozitare = dateFisier[(int)CampuriClient.PERIOADADEPOZIT];
            Telefon = dateFisier[(int)CampuriClient.TELEFON];
            Email = dateFisier[(int)CampuriClient.EMAIL];

            Carduri = new List<string>();
            //adauga mai multe elemente in lista de discipline
            Carduri.AddRange(dateFisier[(int)CampuriClient.CARDURI].Split(SEPARATOR_SECUNDAR_FISIER));
            
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
            string sirConversie = string.Format("\n\n----------------------------------------------------------------\n\nID Client               :   {0}\nNume                   :    {1}\nPrenume              :    {2}\nCNP                     :   {3}\nAnul nașterii         :   {8}\nSold Curent          :   {4} LEI\nPerioada Depozit  :   {5} luni\nDobanda              :   {6}%\nCard                     :   {9}\n\nSold la finalul depozitului: {7} LEI.\n\n----------------------------------------------------------------\n", IDClient, Nume, Prenume, CNP, soldCont, perioadaDepozitare, Dobanda, getSoldFinalPerioada,AnNastere,CarduriAsString);
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
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}",
                SEPARATOR_PRINCIPAL_FISIER, IDClient.ToString(), (Nume ?? " NECUNOSCUT "), (Prenume ?? " NECUNOSCUT "), (CNP ?? " NECUNOSCUT "), AnNastere,(soldCont ?? " NECUNOSCUT "), (perioadaDepozitare ?? " NECUNOSCUT "), (Telefon ?? " NECUNOSCUT "), (Email ?? " NECUNOSCUT "), CarduriAsString);

            return s;
        }
    }
}
