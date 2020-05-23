using System;
using System.Collections.Generic;

namespace LibrarieClient
{
    [Serializable]
    public class Client
    {
        //constante
        private const bool SUCCES = true;
        private const string SEPARATOR_AFISARE = " ";
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ' ';


        static Random numar = new Random();

        public static int nrClienti = 0;
        public string SOLD_CONT { get; set; }
        public string PERIOADA_DEPOZITARE { get; set; }
        public int ID_CLIENT { get; set; }
        public string NUME { get; set; }
        public string PRENUME { get; set; }
        public string CNP { get; set; }
        public string TELEFON { get; set; }
        public string EMAIL { get; set; }
        public DateTime DATA_DEPUNERE { get; set; }
        public DateTime DATA_FINAL_PERIOADA
        {
            get
            {
                return DATA_DEPUNERE.AddMonths(Int32.Parse(PERIOADA_DEPOZITARE));
            }
        }
        public List<string> Carduri { get; set; }

        public int AN_NASTERE{ get; set; }

        public string CARDURI
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
            ID_CLIENT = numar.Next(100000000, 1000000000);
            NUME = string.Empty;
            PRENUME = string.Empty;
            CNP = string.Empty;
            SOLD_CONT = string.Empty;
            PERIOADA_DEPOZITARE = string.Empty;
            TELEFON = string.Empty;
            EMAIL = string.Empty;
            nrClienti++;
        }

        public Client(string _Nume, string _Prenume, string _CNP, string _soldCont, string _perioadaDepozitare, string _telefon, string _email)
        {
            ID_CLIENT = numar.Next(100000000, 1000000000);
            NUME = _Nume.ToUpper();
            PRENUME = _Prenume.ToUpper();
            CNP = _CNP;
            SOLD_CONT = _soldCont;
            PERIOADA_DEPOZITARE = _perioadaDepozitare;
            TELEFON = _telefon;
            EMAIL = _email;

            nrClienti++;
        }

        public Client(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ToString()
            ID_CLIENT = Convert.ToInt32(dateFisier[(int)CampuriClient.ID]);
            NUME = dateFisier[(int)CampuriClient.NUME];
            PRENUME = dateFisier[(int)CampuriClient.PRENUME];
            CNP = dateFisier[(int)CampuriClient.xCNP];
            AN_NASTERE = Int32.Parse(dateFisier[(int)CampuriClient.AN_NASTERE]);
            SOLD_CONT = dateFisier[(int)CampuriClient.SOLD];
            PERIOADA_DEPOZITARE = dateFisier[(int)CampuriClient.PERIOADADEPOZIT];
            TELEFON = dateFisier[(int)CampuriClient.TELEFON];
            EMAIL = dateFisier[(int)CampuriClient.EMAIL];
            Carduri = new List<string>();
            //adauga mai multe elemente in lista de carduri
            Carduri.AddRange(dateFisier[(int)CampuriClient.CARDURI].Split(SEPARATOR_SECUNDAR_FISIER));
            DATA_DEPUNERE = Convert.ToDateTime(dateFisier[(int)CampuriClient.DATADEPUNERE]);
            
            nrClienti++;
        }
        public float DOBANDA
        {
            get
            {
                return float.Parse(PERIOADA_DEPOZITARE) * 63 / 932 % 100;
            }
        }

        public float addSumaSoldCont(float _sumaBani)
        {
            float.Parse(SOLD_CONT += _sumaBani);
            return float.Parse(SOLD_CONT);
        }

        public float SOLD_FINAL
        {
            get
            {
                return float.Parse(SOLD_CONT) + float.Parse(SOLD_CONT) * DOBANDA / 100;
            }
        }

        public string ConversieLaSir_PentruFisier()
        {
            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}{0}{9}{0}{10}{0}{11}{0}{12}",
                SEPARATOR_PRINCIPAL_FISIER, ID_CLIENT.ToString(), (NUME ?? " NECUNOSCUT "), (PRENUME ?? " NECUNOSCUT "), (CNP ?? " NECUNOSCUT "), AN_NASTERE,(SOLD_CONT ?? " NECUNOSCUT "), (PERIOADA_DEPOZITARE ?? " NECUNOSCUT "), (TELEFON ?? " NECUNOSCUT "), (EMAIL ?? " NECUNOSCUT "), CARDURI, DATA_DEPUNERE, DATA_FINAL_PERIOADA);

            return s;
        }
        public override string ToString()
        {
            return ConversieLaSir_PentruFisier();
        }
    }
}
