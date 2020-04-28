using LibrarieClient;
using System;
using System.Collections;

namespace NivelAccesDate
{
    //clasa AdministrareStudenti_FisierBinar implementeaza interfata IStocareData
    public class AdministrareClienti_FisierBinar : IStocareData
    {
        string NumeFisier { get; set; }
        public AdministrareClienti_FisierBinar(string numeFisiser)
        {
            this.NumeFisier = NumeFisier;
        }

        public LibrarieClient.Client[] GetClienti(out int nrClienti)
        {
            throw new Exception("Optiunea GetClienti cu un parametru nu este implementata");
        }
        public void AddClient(Client s)
        {
            throw new Exception("Optiunea AddClient nu este implementata");
        }

        public ArrayList GetClienti()
        {
            throw new Exception("Optiunea GetClient nu este implementata");
        }

        public Client GetClient(string nume, string prenume)
        {
            throw new Exception("Optiunea GetClient nu este implementata");
        }

        public bool UpdateClient(Client s)
        {
            throw new Exception("Optiunea UpdateClient nu este implementata");
        }
    }
}