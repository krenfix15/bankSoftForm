using System;
using LibrarieClient;
using NivelAccesDate;

namespace bankSoftConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data de astăzi : {0} ", DateTime.Now.ToString("dd.MM.yyyy"));
            Console.WriteLine("Ora            : {0} \n", DateTime.Now.ToString("h:mm:ss tt"));

            LibrarieClient.Client[] Clienti;
            IStocareData adminClienti = StocareFactory.GetAdministratorStocare();
            int nrClienti;
            Clienti = adminClienti.GetClienti(out nrClienti);
            LibrarieClient.Client.nrClienti = nrClienti;

            string optiune;

            do
            {
                Console.WriteLine("TASTA L - LISTARE CLIENTI");
                Console.WriteLine("TASTA A - ADAUGARE CLIENT");
                Console.WriteLine("TASTA C - ADAUGARE SUMA CLIENT");
                Console.WriteLine("TASTA X - INCHIDERE PROGRAM\n");
                Console.WriteLine("INTRODUCETI OPTIUNEA: ");
                optiune = Console.ReadLine();

                switch (optiune.ToUpper())
                {
                    case "L":
                        AfisareClienti(Clienti, nrClienti);
                        break;

                    case "A":
                        LibrarieClient.Client c = CitireClientTastatura();
                        Clienti[nrClienti] = c;
                        nrClienti++;
                        //adaugare client in fisier
                        adminClienti.AddClient(c);
                        break;

                    case "C":
                        Console.WriteLine("Introduceti CNP-ul clientului cautat: ");
                        string CNP = Console.ReadLine();

                        LibrarieClient.Client client_cautat = GetIdClient(Clienti, nrClienti, CNP);
                        if (client_cautat != null)
                        {
                            Console.WriteLine("Introdu noua suma adaugata: ");
                            float sumaNoua = float.Parse(Console.ReadLine());
                            client_cautat.addSumaSoldCont(sumaNoua);
                        }
                        else Console.WriteLine("Nu s a gasit clientul.");

                        break;

                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");
        }
        public static void AfisareClienti(LibrarieClient.Client[] clienti, int nrClienti)
        {
            Console.WriteLine("Clientii sunt: \n");
            for (int i = 0; i < nrClienti; i++)
            {
                Console.WriteLine(clienti[i].ConversieLaSir());
            }
        }
        public static LibrarieClient.Client GetIdClient(LibrarieClient.Client[] clienti, int nr_clienti, string CNP)
        {
            for (int i = 0; i < nr_clienti; i++)
            {
                if (clienti[i].CNP == CNP)
                    return clienti[i];
            }
            return null;
        }

        public static LibrarieClient.Client CitireClientTastatura()
        {
            Console.WriteLine("Introduceti numele: ");
            string Nume = Console.ReadLine();

            Console.WriteLine("Introduceti prenumele: ");
            string Prenume = Console.ReadLine();

            Console.WriteLine("Introduceti CNP-ul: ");
            string CNP = Console.ReadLine();

            Console.WriteLine("Introduceti suma de depozitat (LEI): ");
            string Sold = Console.ReadLine();

            Console.WriteLine("Introduceti perioada de depozitare (LUNI): ");
            string perioadaDepozitare = Console.ReadLine();

            string Telefon = "2132433";
            string Email = "dqwdq@yahoo.com";
            Console.WriteLine("\n-----------------------------------------------------\n");


            Console.WriteLine("Alegeti un program de studiu: ");
            Console.WriteLine("1 - Student \n" +
                              "2 - Civil \n" +
                              "3 - Pensionar \n");

            int Optiune = Convert.ToInt32(Console.ReadLine());
            LibrarieClient.Client client = new LibrarieClient.Client(Nume, Prenume, CNP, Sold, perioadaDepozitare, Telefon, Email);

            return client;
        }
    }
}
